using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxTemp : EnemyBox
{
    Color cambioAmarillo = Color.yellow;

    public GameObject cuboAmarillo;
    public override void PlayerInteractua()
    {
        Debug.Log("Cambio tiempo");
        Invoke("CambioAmarillo", 4f);
    }

    void CambioAmarillo()
     {
       cuboAmarillo.GetComponent<Renderer>().material.color = cambioAmarillo;  
     }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
