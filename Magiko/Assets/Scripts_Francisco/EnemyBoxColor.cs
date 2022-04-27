using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxColor : EnemyBox
{
    Color cambioRojo = Color.red;

    public GameObject cuboRojo;

    public override void PlayerInteractua()
    {
        Debug.Log("Cambio color");
        cuboRojo.GetComponent<Renderer>().material.color = cambioRojo;
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
