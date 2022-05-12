using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CambioEscenaTime : MonoBehaviour
{
     float tiempoInicio = 0f;
     float tiempoFinal = 15f;

    void Update()
    {
        tiempoInicio += Time.deltaTime;
        if (tiempoInicio >= tiempoFinal)
        {
            
              SceneManager.LoadScene(1);
        }
    }
}
