using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxPista : EnemyBox
{
    Color cambioVerde = Color.green;

    public GameObject flecha;
    public Material renderMaterial;
    public GameObject cuboGira;
    public override void PlayerInteractua()
    {
        if (flecha != null)
        {
            flecha.SetActive(true);
            cuboGira.GetComponent<Renderer>().material = renderMaterial;
            flecha.GetComponent<Renderer>().material.color = cambioVerde;

            Destroy(flecha, 7);
        }
    }

    void Start()
    {
        flecha.SetActive(false);
    }
}
