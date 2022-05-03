using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxColor : EnemyBox
{
    Color cambioVerde = Color.green;

    public GameObject cuboRojo;

    public override void PlayerInteractua()
    {
        Debug.Log("Cambio color verde Cubo  BUENO");
        cuboRojo.GetComponent<Renderer>().material.color = cambioVerde;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
