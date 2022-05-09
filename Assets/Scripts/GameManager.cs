using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public class GameObject pumpkinPrefab;
    public class GameObject[] pinsPrefab;

    // Start is called before the first frame update
    void SpawnAll()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(pinsPrefab[i], pinsPrefab[i].transform.position, pinsPrefab[i].transform.rotation);
        }
        Instantiate(pumpkinPrefab, pumpkinPrefab.transform.position, pumpkinPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Awake()
    {
        SpawnAll();
    }
}
