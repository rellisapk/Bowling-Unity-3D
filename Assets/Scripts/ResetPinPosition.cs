using UnityEngine;
using System.Collections;

public class ResetPinPosition : MonoBehaviour
{
    public Vector3 position;
    public Quaternion rotation;

    void OnEnable()
    {
        position = gameObject.transform.position;
        rotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    public void ResetPin(object _ball)
    {
        gameObject.transform.position = position;
        gameObject.transform.rotation = rotation;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}
