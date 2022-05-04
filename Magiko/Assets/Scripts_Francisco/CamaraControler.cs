using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControler : MonoBehaviour
{
    [SerializeField] Camera camaraZoom;
    [SerializeField] Camera camaraPrincipal;
    [SerializeField] AnimationCurve curva;
    public float tiempoDuracion;
    Camera estaCamara;
    // Start is called before the first frame update
    void Start()
    {
        estaCamara = gameObject.GetComponent<Camera>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(TransicionCamara(tiempoDuracion));        
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(CamaraTransicionVuelta(tiempoDuracion));        
        } 
    }
    float tiempo = 0;
    IEnumerator TransicionCamara (float tiempoDuracion)
    {
        while (tiempo<tiempoDuracion)
        {
            gameObject.transform.position = Vector3.Lerp (camaraPrincipal.transform.position, camaraZoom.transform.position, curva.Evaluate((1f/tiempoDuracion) * tiempo));
            Debug.Log("Posión 1" + camaraPrincipal.transform.position);
            gameObject.transform.rotation = Quaternion.Slerp(camaraPrincipal.transform.rotation, camaraZoom.transform.rotation, curva.Evaluate ((1f / tiempoDuracion) * tiempo));
            estaCamara.fieldOfView = Mathf.Lerp(camaraPrincipal.fieldOfView, camaraZoom.fieldOfView, curva.Evaluate((1f / tiempoDuracion) * tiempo));
            tiempo = tiempo + Time.deltaTime;
            yield return null;
        }
        tiempo = 0;
        gameObject.transform.position = camaraZoom.transform.position;
    }
    IEnumerator CamaraTransicionVuelta(float tiempoDuracion)
    {
        while (tiempo < tiempoDuracion)
        {
            gameObject.transform.position = Vector3.Lerp(camaraZoom.transform.position, camaraPrincipal.transform.position, curva.Evaluate ( (1f / tiempoDuracion) * tiempo));
            Debug.Log("Posicion 2" + camaraPrincipal.transform.position);
            gameObject.transform.rotation = Quaternion.Slerp(camaraZoom.transform.rotation, camaraPrincipal.transform.rotation, curva.Evaluate ( (1f / tiempoDuracion) * tiempo));
            estaCamara.fieldOfView = Mathf.Lerp(camaraZoom.fieldOfView, camaraPrincipal.fieldOfView, curva.Evaluate((1f / tiempoDuracion) * tiempo));
            tiempo = tiempo + Time.deltaTime;
            yield return null;
        }
        tiempo = 0;
        gameObject.transform.position = camaraPrincipal.transform.position;
    }
}
