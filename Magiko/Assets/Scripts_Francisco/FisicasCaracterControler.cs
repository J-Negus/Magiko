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

    //public float sensibilidadTeclas = 120.0f; //almu variable publica sensibidadTeclas inicializo 120.0f
    //public Camera camara;                     //almu introduzco la camara en public para incluirla en el inspector                      
    //public float giroplayerCabeza;            //almu variable publica giroplayerCabeza

    //Cambio de color de caja
    //public Renderer _renderer;

    void Start()
    {
        _characterControler = GetComponent<CharacterController>();

        //camara = GetComponentInChildren<Camera>(); //almu iniciliza la variable camara 
        //giroplayerCabeza = camara.transform.rotation.x; //almu transform  sobre eje X si movemos acumuluma angulo

        if (_characterControler is null)
        {
            Debug.Log("Character controler es Nulo");
        }

       // _renderer = GetComponent<Renderer>();
    }

    void Update()
    {

        if (true)
        {

        }
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(-verticalInput, 0, horizontalInput);
        Vector3 velocity = direccion * velocidad;

        //float xR = Input.GetAxis("Horizontal") * sensibilidadTeclas * Time.deltaTime; // almu cada vez mueva horizontal xR acumula angulo o disminuye
        //float yR = Input.GetAxis("Vertical") * sensibilidadTeclas * Time.deltaTime;    // almu cada vez mueva vertical yR acumula angulo o disminuye
        //giroplayerCabeza -= verticalInput;                                                       // almu voy acumulando el desplazamiento del player sobre angulo cabeza position inicializo player X0 Y0.738 Z0.23
        //giroplayerCabeza = Mathf.Clamp(giroplayerCabeza, -45, 45);                    // almu con funion Math y con clamp limito angulo 45 grados


        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    transform.Rotate(0, horizontalInput, 0);                                                   // almu trasladamos la rotacion acumulasa a la camara 
        //    camara.transform.localRotation = Quaternion.Euler(giroplayerCabeza, 0, 0);    // almu asignamos la rotación en el espacio giro 3 dimensiones quaternion euler limita rago eje Y e Z no giro angulo
        //}
            if (_characterControler.isGrounded) //si el charqacter controler esta tocando suelo
            {
                if (Input.GetKeyDown(KeyCode.Space))//y pulsamos Espacio
                {
                    impulsoGravedad = alturaSalto;
                }
            }
            else
            {
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
