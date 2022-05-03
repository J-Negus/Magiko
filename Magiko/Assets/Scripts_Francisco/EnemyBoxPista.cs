using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxPista : EnemyBox
{
    Color cambioVerde = Color.green;

    //public GameObject cuboPista;
    public GameObject flecha;

    public override void PlayerInteractua()
    {
        
        if (flecha != null)
        {
            flecha.SetActive(true);
            Debug.Log("Flecha destino activa muestra camino");
            flecha.GetComponent<Renderer>().material.color = cambioVerde;

            Destroy(flecha, 7);
        }
    }

    void Start()
    {
        flecha.SetActive(false);
    }

    void Update()
    {

    }
}
