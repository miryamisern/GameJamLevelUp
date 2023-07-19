using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
      
    [SerializeField] float destroyDelay;

    /*void OnCollisionEnter(Collision other)
    {
        Debug.Log("Has chocado!");

    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PickUpWaste")
        {
            Debug.Log("Residu Reciclat! ");
            /*
            Amb la variable Destroy() destruim un gameObject. Aquesta necesita 2 valors: 
            1) Coneixer l'objecte que esta destruïnt i 
            2) Saber el temps que ha d'esperar a destruïr-ho
            En aquest cas el codi ja ens determina només s'aplicarà a objectes que tinguin la tag "Package"
            */

            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "PickUpAnimal")
        {
            Debug.Log("Has salvat un animal!");
            /*
            Amb la variable Destroy() destruim un gameObject. Aquesta necesita 2 valors: 
            1) Coneixer l'objecte que esta destruïnt i 
            2) Saber el temps que ha d'esperar a destruïr-ho
            En aquest cas el codi ja ens determina només s'aplicarà a objectes que tinguin la tag "Package"
            */

            Destroy(other.gameObject, destroyDelay);
        }


    }



}
