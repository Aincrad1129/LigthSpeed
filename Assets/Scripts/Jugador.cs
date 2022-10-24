using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 10.0f;
    }

    void Update()
    {
        m_Rigidbody.velocity = transform.forward * m_Speed;
       
    }

}

