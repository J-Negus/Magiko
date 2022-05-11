using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    Animator animatorPlayer;
    

    //Cambio de color de caja
    //public Renderer _renderer;

    void Start()
    {
        animatorPlayer = GetComponent<Animator>();
        _characterControler = GetComponent<CharacterController>();
        if (_characterControler is null)
        {
            Debug.Log("Character controler es Nulo");
        }

       // _renderer = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(verticalInput, 0, -horizontalInput);
        Vector3 velocity = direccion * velocidad;

       
        if (_characterControler.isGrounded) //si el charqacter controler esta tocando suelo
        {
            if (Input.GetKeyDown(KeyCode.Space))//y pulsamos Espacio
            {
                Debug.Log("Debo de Saltar ");
                animatorPlayer.SetTrigger("Saltar");
                //animatorPlayer.SetBool("Caminar", false);
                //animatorPlayer.SetBool("Morir", false);
                //animatorPlayer.SetBool("Idle", false);
                impulsoGravedad = alturaSalto;
            }

            if (direccion != Vector3.zero) 
            {
                animatorPlayer.SetBool("Caminar", true);
            //    impulsoGravedad = alturaSalto;
            }
            else
            {
                animatorPlayer.SetBool("Caminar", false);
            }
        }
        else
        {
            impulsoGravedad -= gravedad; //si el player esta en el suelo le quitamos la gravedad
        }
        velocity.y = impulsoGravedad;
            _characterControler.Move(velocity * Time.deltaTime);
        //    _characterControler.Move(velocity * Time.deltaTime);
    }

    bool vivo = true;
    internal void Morir()
    {
        if (vivo)
        { 
           animatorPlayer.SetTrigger("Morir");
            Debug.Log("COLISIONADO PLAYER MUERE");
            vivo = false;
        }
    }bool vivo2 = true;
    internal void Morir2()
    {
        if (vivo2)
        { 
           animatorPlayer.SetTrigger("Morir2");
            Debug.Log("COLISIONADO PLAYER MUERE2");
            vivo2 = false;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.tag.Equals("Enemy"))
        {
            hit.collider.GetComponent<EnemyBox>().PlayerInteractua();
            
        }

    

    }
  
     

}
