using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxDestroy : EnemyBox
{
    public GameObject cuboDestroy;
    public override void PlayerInteractua()
    {
        Debug.Log("Adios paco");
        Destroy(cuboDestroy);
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
