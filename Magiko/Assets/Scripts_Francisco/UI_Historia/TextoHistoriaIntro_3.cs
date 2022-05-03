using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoHistoriaIntro_3 : TextoHistoriaIntro
{
    public GameObject dialogo_3;
    public void TextosIntro()
    {
        if (dialogo_3 != null)
        {
            dialogo_3.SetActive(true);
        }
    }
}
