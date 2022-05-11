using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGolpeNegro : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        
            other.GetComponent<FisicasCaracterControler>().Morir2();
        
    }
}
