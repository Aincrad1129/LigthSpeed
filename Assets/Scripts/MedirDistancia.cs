using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace data
{
    public class MedirDistancia : MonoBehaviour
    {

       [SerializeField] private Transform checkPoint;
       [SerializeField] private Text distanceText;
       private float distancia;
       private GuardarCargar guardarDatos;
       private DatosGuardar mod;

        private void start()
        {
            guardarDatos.DataLoaded += OnDataLoaded;
        }
        private void OnDataLoaded()
        {
            DistanceCalcu(mod.distancia);
        }
        void Update()
        {
            DistanceCalcu(distancia);
            if(Input.GetKeyDown(KeyCode.S))
            {
                guardarDatos.GuardarDatos();
            }
        }

        private void DistanceCalcu(float distance)
        {   
            distance = (checkPoint.transform.position.x - transform.position.z);
            distanceText.text= "Distancia: " + distance.ToString("F1") + "Mts";
            if(distance <=0)
            {
                distanceText.text = "Meta";
            }
        }
    }
}