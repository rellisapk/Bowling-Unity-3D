using UnityEngine;
using System.Collections;

public class PinFall : MonoBehaviour
{
    public Vector3 posisiAwal;
    public Quaternion rotasiAwal;
    public bool fall = false;

    void Start() {
        posisiAwal = gameObject.transform.position;
        rotasiAwal = gameObject.transform.rotation;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ground")){
            fall = true;
        }
    }

    public void ResetPin() {
        gameObject.transform.position = posisiAwal;
        gameObject.transform.rotation = rotasiAwal;
        fall = false;
    }
}