using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    // variables para el funcionamiento del sonido 

    public Sonido[] Musica, SfxSonidos;
    public AudioSource Musicasource, Sfxsourse;
  

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        PlayMusica("Musica");
    }

   
    private void Update()
    {
        
       
    }


   
    public void PlayMusica(string name)
    {
        Sonido s = Array.Find(Musica, x => x.nombre == name);
        if (s == null)
        {
            Debug.Log("not found! musica");
        }
        else
        {
            Musicasource.clip = s.clip;
            Musicasource.Play();
            
        }

    }
    
    public void PlaySFX(string name)
    {
        Sonido s = Array.Find(SfxSonidos, x => x.nombre == name); 
        if (s == null)
        {
            Debug.Log("not found!");
        }
        else
        {
            Sfxsourse.PlayOneShot(s.clip);
        }
    }

   
}