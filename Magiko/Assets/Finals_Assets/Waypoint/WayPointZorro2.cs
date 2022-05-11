using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WayPointZorro2 : MonoBehaviour
{
    public float speed = 0.5f;
    public Transform target; // crea obejeto con targer donde tiene que ir
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime)); //mascota anda hacia adelante
    }
    void OnTriggerEnter(Collider other) // funcion ontrigger en momento que toca con algo
    {
        if (other.tag == "WayPoint") // si el objeto es = WayPoint
        {
            target = other.gameObject.GetComponent<WayPointZorro>().nextPoint; // coger componente que hemos crado Waipoint hacia objeto que vamos nextpoint los 2 son transform
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z)); // hacer lookAt para que mire al nuevo punto con vector 3 nuevas coordenadas del target, position y para que no vuele
        }
    }
}