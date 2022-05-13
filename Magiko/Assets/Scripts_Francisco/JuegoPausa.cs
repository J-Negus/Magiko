using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class JuegoPausa : MonoBehaviour
{
    public bool juegoEnPausa = false;
    [SerializeField]
    private Button boton1;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//pausamos el juego con Esc
        {
            PausarJuego();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            PlayJuego();
        }
    }

    public void QuitGame()
    { //METODO DE CIERRE JUEGO
        Application.Quit();
        Debug.Log("Juego Cerrado");
    }

    public void PausarJuego()
    { //METODO PAUSAR EL JUEGO //
        Time.timeScale = 1;
    }

    public void PlayJuego()
    { //METODO PAUSAR EL JUEGO //
        Time.timeScale = 1;
    }
}
