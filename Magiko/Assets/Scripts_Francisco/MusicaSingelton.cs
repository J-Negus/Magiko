using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaSingelton : MonoBehaviour
{
    public static MusicaSingelton inst;
    void Awake()
    {
        if (MusicaSingelton.inst == null)
        {
            MusicaSingelton.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
