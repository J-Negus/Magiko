using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    float tiempo = 100f;
    [SerializeField]
    Image imagenFade;
    public float tiempoDuracion = 2f;
    public void SetFade() 
    {
        tiempo = 0f;
    }
    
   void Update ()
    {
        Invoke("FadeOnn", 30);//funciona ok tiempo definido inicio/fin fade
    }

    public void FadeOff() 
    {
        imagenFade.color = new Color(0, 0, 0, 0);//valor boleano
    }
    public void FadeOnn() 
    {
        if (tiempo < tiempoDuracion)
        {
            tiempo += Time.deltaTime;//secundero
            imagenFade.color = new Color(0, 0, 0, (1f / tiempoDuracion) * tiempo);//valor boleano
            //
        }
    }
}
