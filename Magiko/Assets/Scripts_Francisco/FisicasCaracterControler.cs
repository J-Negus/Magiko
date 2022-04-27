using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicasCaracterControler : MonoBehaviour
{
    [SerializeField]
    private float velocidad ;
    [SerializeField]
    private float gravedad = 1f;
    [SerializeField]
    private float alturaSalto;
    private float impulsoGravedad;

    private CharacterController _characterControler;

    //Cambio de color de caja
    
   


    //public Renderer _renderer;

    
    


   
    void Start()
    {
        _characterControler = GetComponent<CharacterController>();

        if (_characterControler is null)
        {
            Debug.Log("Character controler es Nulo");
        }

       // _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(-verticalInput, 0, horizontalInput);
        Vector3 velocity = direccion * velocidad;

        if (_characterControler.isGrounded) //si el charqacter controler esta tocando suelo
        {
            if (Input.GetKeyDown(KeyCode.Space))//y pulsamos Espacio
            {
                impulsoGravedad = alturaSalto;
            }
        }
        else {
            impulsoGravedad -= gravedad; //si el player esta en el suelo le quitamos la gravedad
        }
        velocity.y = impulsoGravedad;
        _characterControler.Move(velocity * Time.deltaTime);
        _characterControler.Move(velocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag.Equals("Enemy"))
        {
            hit.collider.GetComponent<EnemyBox>().PlayerInteractua();
            //
        }


        //if (hit.collider.tag.Equals("Enemy_Color"))
        //{
        //    
        //}


        //if (hit.collider.tag.Equals("Enemy_ColorTime"))
        //{          
        //              
        //}

    }

     

}
