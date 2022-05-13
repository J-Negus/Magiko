using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VolumeValueChange : MonoBehaviour
{
    private AudioSource audioSrc;

    // Volumen de la musica modificable
    private float musicVolume = 0.5f;
    
    void Start()
    {
        //asigno el componente para controlar
        audioSrc = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        audioSrc.volume = musicVolume;
    }
    
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}