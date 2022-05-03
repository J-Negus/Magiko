using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMovimientoAnimacion : MonoBehaviour
{
    private enum Axis {X,Y,Z};
    [SerializeField]
    private Axis movimientoAxis;

    [SerializeField]
    private Axis rotacionAxis;

    [SerializeField]
    [Range(0f, 5f)]
    private float velocidadRotacion;
    [SerializeField]
    [Range(0f, 5f)]
    private float amplitudMovimiento;
    
    [SerializeField]
    [Range(0f, 5f)]
    private float frecuenciaMovimiento;
    float incrementoRadio;
    float radio = 0;
    private float inicioX, inicioY, inicioZ;

    void Start()
    {
        incrementoRadio = 2 * Mathf.PI * frecuenciaMovimiento;
        inicioX = transform.position.x;
        inicioY = transform.position.y;
        inicioZ = transform.position.z;
    }

    void FixedUpdate()
    {
        Movimiento();
        Rotacion();       
         
    }

    private void Rotacion()
    {
        switch (rotacionAxis)
        {
            case Axis.X:
                transform.Rotate(velocidadRotacion * Vector3.right);
                break;
            case Axis.Y:
                transform.Rotate(velocidadRotacion * Vector3.up);
                break;
            case Axis.Z:
                transform.Rotate(velocidadRotacion * Vector3.forward);
                break;
        }
    }

    private void Movimiento()
    {
        incrementoRadio = 2 * Mathf.PI * frecuenciaMovimiento;

        switch (movimientoAxis)
        {
            case Axis.X:
                transform.position = new Vector3(inicioX + amplitudMovimiento * Mathf.Sin(radio),transform.position.y, transform.position.z);
                break;
            case Axis.Y:
                transform.position = new Vector3(transform.position.x, inicioY + amplitudMovimiento * Mathf.Sin(radio), transform.position.z);
                break;
            case Axis.Z:
                transform.position = new Vector3(transform.position.x, transform.position.y, inicioZ + amplitudMovimiento * Mathf.Sin(radio));
                break;
        }

        radio += incrementoRadio * Time.fixedDeltaTime;
        if (radio > 2 * Mathf.PI)
        {
            radio = 0;
        }
    }

}
