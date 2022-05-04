using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoHistoriaIntro_2 : MonoBehaviour
{

    public Animator animacioFade;
    public GameObject dialogo_2;

    private void Awake()
    {
        animacioFade.StopPlayback();
    }
    public void TextosIntro()
    {
        if (dialogo_2 != null)
        {
            dialogo_2.SetActive(true);
            
        }
    }
    public void AnimacionFadeNegro()//testeando el fade, no acaba6
    {
        animacioFade.Play("Fade",20);
        GetComponent<Animator>().StopPlayback();
    }
   
}
