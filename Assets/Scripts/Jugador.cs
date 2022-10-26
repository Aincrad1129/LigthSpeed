using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float vel;
    public int vida;
    public Joystick stick;
    Rigidbody m_Rigidbody;
    public GameObject PanelGameOver;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        PanelGameOver.SetActive(false);
    }
    void Update()
    {
        PlayerMov();
        Perder();
    }

    void PlayerMov()
    {
        float x;
        x = stick.Horizontal + Input.GetAxis("Horizontal");
        transform.Translate(x * vel * Time.deltaTime, 0f, 0f);

        m_Rigidbody.velocity = transform.forward * vel;
    }

    void Perder()
    {
       
        if (vida <= 0)
        {
            vel = 0;
            print("PERDIO POR LOCA");
            PanelGameOver.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "meteorito")
        {
            vida -=  1;
            Destroy(collision.gameObject);
            AudioManager.Instance.Musicasource.Stop();
        }
    }
}

