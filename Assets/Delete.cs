using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public float vel;
   public Rigidbody m_Rigidbody;
    
     void Update()
    {
        m_Rigidbody.velocity = transform.forward * vel;
     }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "meteorito")
        {
            Destroy(collision.gameObject);
            print("collider");
        }
    }
}
