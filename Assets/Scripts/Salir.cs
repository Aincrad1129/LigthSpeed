using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Salir : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SalirApp()
    {
        Application.Quit();
        Debug.Log("se salio");
    }
    public void Reiniciar()
    {
        AudioManager.Instance.Musicasource.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void Inicia()
    {
        SceneManager.LoadScene(1);
        print("carga");
    }

    
}
 