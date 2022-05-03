using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxTemp : EnemyBox
{
    Color cambioAmarillo = Color.yellow;

    public GameObject cuboAmarillo;
    public override void PlayerInteractua()
    {
        Debug.Log("Cambia Color amarillo 2 seg y destruye a 4 seg");
        Invoke("CambioAmarillo", 2f);
        Invoke("DestruyeCubo", 4f);

    }

    void CambioAmarillo()
     {
       cuboAmarillo.GetComponent<Renderer>().material.color = cambioAmarillo;  
     }
    void DestruyeCubo() 
    {
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
