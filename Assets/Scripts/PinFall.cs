using UnityEngine;
using System.Collections;

public class PinFall : MonoBehaviour
{
    public Vector3 posisiAwal;
    public Quaternion rotasiAwal;

    void Start() {
        posisiAwal = gameObject.transform.position;
        rotasiAwal = gameObject.transform.rotation;
    }

    public bool PinJatuh() {
        if (gameObject.transform.rotation.z != 0){
            return true;
        }

        return false;
    }

    public void ResetPin() {
        gameObject.transform.position = posisiAwal;
        gameObject.transform.rotation = rotasiAwal;
    }
}