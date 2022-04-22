using UnityEngine;
using System.Collections;

public class RollBall : MonoBehaviour
{
    public float ballSpeed = 1000f;
    public float moveSpeed = 5f;

    public Transform PumpkinSpawn;

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(ballSpeed * transform.forward);
    }

    void Update()
    {
        Vector3 move = Vector3.zero;
        move.z = Input.GetAxis("Horizontal");

        transform.position += move * moveSpeed * Time.deltaTime;
    }

    public void Reset(object _ball)
    {
        gameObject.transform.position = PumpkinSpawn.position;
        gameObject.transform.rotation = PumpkinSpawn.rotation;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}


