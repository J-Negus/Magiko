using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestriccionPosicion : MonoBehaviour
{
    [SerializeField] Transform objetivo; 
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.position = objetivo.transform.position;
    }
}
