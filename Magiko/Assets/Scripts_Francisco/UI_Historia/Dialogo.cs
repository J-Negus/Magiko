using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [SerializeField]
    Dialogo siguienteDialogo;
    [SerializeField]
    Text texto;
    [SerializeField]
    bool fade = false;
    [SerializeField]
    Fade imagenFade;

    public void IniciarDialogo() //texto dialogos 1,2,3,4
    {
    
    }

    public void FinalizarDialogo() //llamar siguiente                       FADE 2,3,4 7
    {
        if (fade == true)
        {
            siguienteDialogo.gameObject.SetActive(true);//
            imagenFade.SetFade();
            siguienteDialogo.IniciarDialogo();//lo inicamos // aplicar un invoke de tiempo
            gameObject.SetActive(false);//desacativamos el actual
        }
        else {
            if (siguienteDialogo != null)
            {
                imagenFade.FadeOff();
                siguienteDialogo.gameObject.SetActive(true);//activamos siguie
                siguienteDialogo.IniciarDialogo();//lo inicamos
                gameObject.SetActive(false);//desacativamos el actual
            }
        }
    }
}
