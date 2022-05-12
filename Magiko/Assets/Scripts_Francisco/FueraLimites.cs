using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FueraLimites : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        FisicasCaracterControler scriptPlayer = other.GetComponent<FisicasCaracterControler>();
        if (scriptPlayer != null)
        {
        scriptPlayer.Morir();//daba error al intentar coger el script
        }

    }
}
