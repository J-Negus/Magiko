using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoHistoriaIntro_5 : TextoHistoriaIntro
{
    public GameObject dialogo_5;
    public void TextosIntro()
    {
        if (dialogo_5 != null)
        {
            dialogo_5.SetActive(true);
        }
    }
}
