using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRight : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField]
    float power;
    public Vector3 posisiAwal;

    public void MoveLeft()
    {
        rb.AddForce(Vector3.left * power * Time.deltaTime);
    }

    public void MoveRight()
    {
        rb.AddForce(Vector3.right * power * Time.deltaTime);
    }
}