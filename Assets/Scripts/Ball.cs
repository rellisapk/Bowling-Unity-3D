using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField]
    float power;
    public Vector3 posisiAwal;
    public Quaternion rotasiAwal;
    public bool bolaLempar = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posisiAwal = gameObject.transform.position;
        rotasiAwal = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !bolaLempar) {
            rb.AddForce(Vector3.forward * power * Time.deltaTime);
            bolaLempar = true;
        }
        
    }

    public void ResetBola(){
        gameObject.transform.position = posisiAwal;
        gameObject.transform.rotation = rotasiAwal;
        rb.velocity = Vector3.zero;
        bolaLempar = false;
    }
}
