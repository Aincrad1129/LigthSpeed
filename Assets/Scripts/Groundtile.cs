using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundtile : MonoBehaviour
{
    private Spawpiso Spawpiso;
    public GameObject[] obstaculos;
    public Transform[] spawnpoints;

    private void Awake()
    {
        Spawpiso = GameObject.FindObjectOfType<Spawpiso>();
    }

    private void OnTriggerExit(Collider other)
    {
        Spawpiso.Spawnpiso();

        Destroy(gameObject, 5f);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
