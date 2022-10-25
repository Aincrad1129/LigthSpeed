using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawpiso : MonoBehaviour
{
    public GameObject Pisoprefab;
    Vector3 NextSpawn;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Spawnpiso();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void Spawnpiso()
    {
        GameObject tempPiso = Instantiate(Pisoprefab, NextSpawn, Quaternion.identity);
        NextSpawn = tempPiso.transform.GetChild(1).transform.position;
    }
}