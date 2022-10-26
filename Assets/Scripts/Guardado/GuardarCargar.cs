using System;
using System.IO;
using UnityEngine;

namespace data
{
    public class GuardarCargar : MonoBehaviour
    {
       private const string FileName = "infoPlayer.data";
       public event Action DataLoaded;
        [SerializeField] private DatosGuardar datosGuardar;
        public DatosGuardar DatosGuardar => datosGuardar;

        [ContextMenu("save")]
        public void GuardarDatos()
        {
            string infoJugador = JsonUtility.ToJson(datosGuardar);
            string path = Path.Combine(Application.persistentDataPath,  FileName);
            File.WriteAllText(path, infoJugador);
            Debug.Log(JsonUtility.ToJson(datosGuardar));
        }

        [ContextMenu("loaded")]
        public void CargarDatos()
        {
            string path = Path.Combine(Application.persistentDataPath,  FileName);
            string infoJugador = File.ReadAllText(path);
            DatosGuardar datosCargados = JsonUtility.FromJson<DatosGuardar>(infoJugador);
            datosGuardar.dinero = datosCargados.dinero;
            datosGuardar.distancia = datosCargados.distancia;
            datosGuardar.ultimaNave = datosCargados.ultimaNave;
            datosGuardar.naves = datosCargados.naves;
            DataLoaded?.Invoke();
        }
    }
}