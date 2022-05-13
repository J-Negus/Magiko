using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_UI : MonoBehaviour
{
    public GameObject panelInicio;
    public GameObject panelAjustes;
    public GameObject panelCreditos;
    void Start()
    {
        panelInicio.SetActive(true);
        panelAjustes.SetActive(false);
        panelCreditos.SetActive(false);
    }

    // Update is called once per frame
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
        Time.timeScale = 1;
    }
    public void SalirDelJuego()
    { //METODO DE CIERRE JUEGO
        Application.Quit();
        Debug.Log("Juego Cerrado");
    }
}
