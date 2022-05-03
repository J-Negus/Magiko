using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoHistoriaIntro_1 : TextoHistoriaIntro
{
    public GameObject dialogo_1;
    public override void TextosIntro()
    {
        dialogo_1.gameObject.SetActive(false);
        Debug.Log("objeto desactivado");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
