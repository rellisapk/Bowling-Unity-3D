using UnityEngine;
using System.Collections;

public class BallReturn : MonoBehaviour
{
    public int _ball = 0;
    bool doUpdate = false;

    void LateUpdate()
    {
        if (doUpdate)
        {
            _ball += 1;
            _ball = _ball % 3;
            StartCoroutine(DelayUpdate());
        }
        doUpdate = false;
    }

    public IEnumerator DelayUpdate()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SendMessage("UpdateScore", _ball, SendMessageOptions.RequireReceiver);
        yield return 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.getComponent<RollBall>() != null)
        {
            doUpdate = true;
            other.gameObject.SendMessage("Reset", _ball, SendMessageOptions.DontRequireReceiver);
        }
    }

    void ResetFrame()
    {
        foreach (var v in GameObject.FindGameObjectsWithTag("Pin"))
        {
            v.SendMessage("ResetPin", (_ball), SendMessageOptions.DontRequireReceiver);
        }
        _ball = 0;
    }
}
