using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoHistoriaIntro_4 : TextoHistoriaIntro
{
    public GameObject dialogo_4;
    public void TextosIntro()
    {
        if (dialogo_4 != null)
        {
            dialogo_4.SetActive(true);
        }
    }
}
