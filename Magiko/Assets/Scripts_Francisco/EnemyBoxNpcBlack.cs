using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxNpcBlack : EnemyBox

{
    Color cambioVerde = Color.green;
    public GameObject enemigoBlackNpc;
    public GameObject Cubo5;
    public Material renderMaterial;

    private void Awake()
    {
        enemigoBlackNpc.SetActive(false);
    }

    public override void PlayerInteractua()
    {
        if (Cubo5 != null)
        {
            Invoke("CambioRojo", 2);
            Invoke("ActivoEnemy", 5);
            Debug.Log("Test enemigo aparece ok");

            
                //  Destroy(enemigoBlackNpc, 7);
            }
        }

        //void Start()
        //{
        //    Cubo5 = GetComponent<GameObject>();
        //    enemigoBlackNpc = GetComponent<GameObject>();
        //    enemigoBlackNpc.SetActive(false);
        //}

        void ActivoEnemy()
        {
            enemigoBlackNpc.SetActive(true);
        }
        void CambioRojo()
        {
            Cubo5.GetComponent<Renderer>().material = renderMaterial;
        }

    //void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.collider.tag.Equals("Player"))
    //    {
    //        //hit.collider.GetComponent<EnemyBox>().PlayerInteractua();
    //        Debug.Log("COLISIONADO PLAYER MUERE");
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (CompareTag("Player"))
        {
            //hit.collider.GetComponent<EnemyBox>().PlayerInteractua();
            Debug.Log("COLISIONADO PLAYER MUERE");
        }
    }
}
    

