using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoxNpcBlack : EnemyBox

{
    Color cambioVerde = Color.green;

    public GameObject enemigoBlackNpc;

    public override void PlayerInteractua()
    {

        if (enemigoBlackNpc != null)
        {
            enemigoBlackNpc.SetActive(true);
            Debug.Log("Flecha Enemigo Npc Negro");
            enemigoBlackNpc.GetComponent<Renderer>().material.color = cambioVerde;

            Destroy(enemigoBlackNpc, 7);
        }
    }

    void Start()
    {
        enemigoBlackNpc.SetActive(false);
    }

    void Update()
    {

    }
}
