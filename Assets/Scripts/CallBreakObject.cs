using UnityEngine;
using System.Collections;

public class CallBreakObject : MonoBehaviour
{
    [HideInInspector]
    public BreakableObject pumpkin;
    
    // Start is called before the first frame update
    void Awake()
    {
        pumpkin = GameObject.FindGameObjectWithTag("Pumpkin").GetComponent<BreakableObject>();
    }

    // Update is called once per frame
    public void OnTrggerEnter(Collider other)
    {
        try
        {
            pumpkin.triggerBreak();
        }
        catch { }
    }
}
