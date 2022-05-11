using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxDestroy : EnemyBox
{
    public GameObject cuboDestroy;
    public override void PlayerInteractua()
    {
       // Debug.Log("Adios paco, cubo destruye al pisarlo");
        Destroy(gameObject);
        //Destroy(cuboDestroy);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
