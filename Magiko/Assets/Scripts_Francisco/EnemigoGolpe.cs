using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGolpe : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        
            other.GetComponent<FisicasCaracterControler>().Morir();
        
    }
}
