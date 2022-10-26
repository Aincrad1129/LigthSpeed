using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundtile : MonoBehaviour
{
    private Spawpiso Spawpiso;
    public GameObject[] obstaculospref;
    public Transform[] spawnpoints;

    private void Awake()
    {
        Spawpiso = GameObject.FindObjectOfType<Spawpiso>();
    }

    private void Start()
    {
        SpawnObst();
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
    public void SpawnObst()
    {
        int ChooseSpawnPoint = Random.Range(0, spawnpoints.Length);
        int SpawnPrefab = Random.Range(0, obstaculospref.Length);

        Instantiate(obstaculospref[SpawnPrefab], spawnpoints[ChooseSpawnPoint].transform.position, Random.rotation);
    }
}
