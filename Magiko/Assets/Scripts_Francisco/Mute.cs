using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public void MutearSonidos() 
    {
        AudioListener.pause = !AudioListener.pause;
    }
}
