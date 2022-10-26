using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] GameObject ObjectToRotate;
    [SerializeField] GameObject[] ObjectsToRotate;
    [Header("Configuration")]
    [SerializeField] bool Multiple;
    [SerializeField] float RotationSpeed = 1F;
    [SerializeField] bool X = false;
    [SerializeField] bool Y = false;
    [SerializeField] bool Z = false;

    void Update()
    {
        if (Multiple == true)
        {
            foreach (GameObject item in ObjectsToRotate)
            {
                if (X == true)
                {
                    item.transform.Rotate(RotationSpeed, 0f, 0f);
                }
                if (Y == true)
                {
                    item.transform.Rotate(0f, RotationSpeed, 0f);
                }
                if (Z == true)
                {
                    item.transform.Rotate(0f, 0f, RotationSpeed);
                }
            }
        }
        else
        {
            if (X == true)
            {
                ObjectToRotate.transform.Rotate(RotationSpeed, 0f, 0f);
            }
            if (Y == true)
            {
                ObjectToRotate.transform.Rotate(0f, RotationSpeed, 0f);
            }
            if (Z == true)
            {
                ObjectToRotate.transform.Rotate(0f, 0f, RotationSpeed);
            }
        }
    }
}
