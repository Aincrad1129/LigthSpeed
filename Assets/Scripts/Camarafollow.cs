using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarafollow : MonoBehaviour
{

    public Transform player;
    Vector3 offset;
    private void Awake()
    {
        player = FindObjectOfType<Jugador>().transform;

    }
    void Start()
    {
        offset = transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetpos = player.position + offset;
        targetpos.x = 0;
        transform.position = targetpos;
    }
}
