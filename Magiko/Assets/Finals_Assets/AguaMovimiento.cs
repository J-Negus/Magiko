using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AguaMovimiento : MonoBehaviour
{
    public float velocidad;

    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset = new Vector2(((Time.time) * velocidad), 0);
    }
}
