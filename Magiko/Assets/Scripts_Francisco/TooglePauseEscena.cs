using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TooglePauseEscena : MonoBehaviour
{
    public Toggle seleccionToogle;

    void Start()
    {
        seleccionToogle = GetComponent<Toggle>();

        seleccionToogle.onValueChanged.AddListener(delegate
        {
            ToogleCambiaValor(seleccionToogle);
        });
    }
    void ToogleCambiaValor(Toggle togleValor)
    {
        Time.timeScale = 0;
        Debug.Log("Cambia bien" + togleValor.isOn);
    }

    void Update()
    {
        
    }
}
