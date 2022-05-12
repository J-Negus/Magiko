using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxTemp : EnemyBox
{
    Color cambioAmarillo = Color.yellow;
    public Material renderMaterial;
    public Rigidbody rigidCaida;
    public GameObject cuboAmarillo;
    float tiempoCaida;

    private void Start()
    {
        rigidCaida = GetComponent<Rigidbody>();
    }
    public override void PlayerInteractua()
    {
       // cuboAmarillo.GetComponent<Renderer>().material = renderMaterial;
      //  Debug.Log("Cambia Color amarillo 2 seg y destruye a 4 seg");
        Invoke("CambioAmarillo", 0.2f);
        Invoke("Caer", RandomTiempoCaida());
        Invoke("DestruyeCubo", 7f);

    }
    float RandomTiempoCaida() {
        tiempoCaida = Random.Range(0.5f, 1.5f);
        return tiempoCaida;
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
