using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedallonAnima : MonoBehaviour
{
    public Animator animacion ;
    
    bool medallonParado = false;
    void Start()
    {
        animacion = GetComponent<Animator>();
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            animacion.Play("GemaFinal1");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            animacion.Play("GemaFinal2");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            animacion.Play("GemaFinal3");
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            animacion.Play("GemaFinal4");
        }
       
    }
    
}
