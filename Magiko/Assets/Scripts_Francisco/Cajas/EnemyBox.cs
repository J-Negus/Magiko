using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour
{
    public virtual void PlayerInteractua()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    Destroy(gameObject);
    //}
    private void OnCollisionEnter(Collision collision)
    {
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Entro al Collider del Cubo");

    //    if (other.tag == "Player")
    //    {
    //        Debug.Log("Comparo con player y debugeo");
    //    }
        
  //  }

    //private void OnTriggerExit(Collider other)
    //{
    //    Debug.Log(" Salimos del Colision");
    //    if (other.tag == "Player")
    //    {
    //        Debug.Log("Estoy saliendo del collider con Exit Trigger");
    //    }

   // }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("COLISIONA");
    //}

}
