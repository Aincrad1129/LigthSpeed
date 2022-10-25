using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorMov : MonoBehaviour
{
    public float vel;
    public Joystick stick;
    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        vel = 10.0f;
    }
    void Update()
    {
        PlayerMov();
    }

    void PlayerMov()
    {
        float x;
        x = stick.Horizontal + Input.GetAxis("Horizontal");
        transform.Translate(x * vel * Time.deltaTime, 0f, 0f);

        m_Rigidbody.velocity = transform.forward * vel;
    }

}
