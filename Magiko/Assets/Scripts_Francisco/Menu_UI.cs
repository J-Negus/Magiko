using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_UI : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelAjustes;
    public GameObject panelCreditos;
    public GameObject botonPause;
    public GameObject botonNoPause;
      
    void Start()
    {
        panelInicio.SetActive(true);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
        botonPause.SetActive(true);
        botonNoPause.SetActive(false);
       
    }
       
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//pausamos el juego con Esc
        {
            MenuInicial();
        }
    }
    public void InicioJuego() 
    {
        panelInicio.SetActive(false);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
    }
    public void PanelAjustes() 
    {
        panelInicio.SetActive(false);
        panelAjustes.SetActive(true);
        panelCreditos.SetActive(false);
    }
    public void PanelCreditos() 
    {
        panelInicio.SetActive(false);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(true);
    }
    public void MenuInicial()
    {
        panelInicio.SetActive(true);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
        Time.timeScale = 0;
    }
    public void SalirDelJuego()//METODO DE CIERRE JUEGO
    { 
        Application.Quit();
        Debug.Log("Juego Cerrado");
    }
    public void PausarJuego()//METODO PAUSAR EL JUEGO //
    {
        botonPause.SetActive(false);
        botonNoPause.SetActive(true);
        Time.timeScale = 0;
    }
    public void PlayPauseJuego()//METODO PAUSAR EL JUEGO //
    {
        botonPause.SetActive(true);
        botonNoPause.SetActive(false);
        Time.timeScale = 1;
    }
}
