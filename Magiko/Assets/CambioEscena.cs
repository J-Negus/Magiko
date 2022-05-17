using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioEscena : MonoBehaviour
{
    public Animator animacion;
    public GameObject medallonAparece;
    void Start()
    {
        animacion = GetComponent<Animator>();
        medallonAparece = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            Debug.Log("CAMBIO DE ESCENA RICAMENTE");
            medallonAparece.SetActive(true);
            animacion.Play("Medallon");
            animacion.Play("GemaFinal1");
        }
    }
    
   
        
    
}
