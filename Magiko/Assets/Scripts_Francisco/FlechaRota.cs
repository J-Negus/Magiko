using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechaRota : MonoBehaviour
{

    Color cambioVerde = Color.green;


    public void RotacionFlecha() { 
        
        
        transform.Rotate(new Vector3(5f, 0, 0));
        Debug.Log("Flecha destino activa muestra camino");
        GetComponent<Renderer>().material.color = cambioVerde;
    }
    private void Update()
    {
        RotacionFlecha();
    }

}
