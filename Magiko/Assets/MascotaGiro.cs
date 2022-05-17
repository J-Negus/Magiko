using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MascotaGiro : MonoBehaviour
{

    public float giro = 0.01f;
    public GameObject playerASeguir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, playerASeguir.transform.position, Time.deltaTime * giro);
       // Quaternion rodea = Quaternion.AngleAxis(transform.position.x * giro, Vector3.back);

       //// Quaternion ladeo = Quaternion.AngleAxis(posRelativaCursor.x * velocidadGirao, Vector3.back);
       // Quaternion cabeceo = Quaternion.AngleAxis(transform.position.y * giro, Vector3.left);//verlocidad giro / 2 rota menos
       // Quaternion cabeladeo = Quaternion.AngleAxis(transform.position.z * giro, Vector3.down);

       // gameObject.transform.rotation = rodea * cabeceo * cabeladeo;
    }
}
