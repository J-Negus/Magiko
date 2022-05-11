using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxTemp : EnemyBox
{
    Color cambioAmarillo = Color.yellow;
    public Material renderMaterial;
    public Rigidbody rigidCaida;
    public GameObject cuboAmarillo;

    private void Start()
    {
        rigidCaida = GetComponent<Rigidbody>();
    }
    public override void PlayerInteractua()
    {
       // cuboAmarillo.GetComponent<Renderer>().material = renderMaterial;
      //  Debug.Log("Cambia Color amarillo 2 seg y destruye a 4 seg");
        Invoke("CambioAmarillo", 2f);
        Invoke("Caer", 4f);
        Invoke("DestruyeCubo", 7f);

    }

    void CambioAmarillo()
     {
        cuboAmarillo.GetComponent<Renderer>().material = renderMaterial;
        //cuboAmarillo.GetComponent<Renderer>().material.color = cambioAmarillo;  
     }
    void DestruyeCubo() 
    {
        Destroy(gameObject);
    }

    void Caer()
    {
        rigidCaida.isKinematic = false;
    }

    void Update()
    {
        
    }
}
