using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{


    public GameObject explosion;
    public GameObject playerExplosion;
  
    
    private void OnTriggerEnter(Collider other) //avoiding boundary

    {
        if (other.tag == "Boundary")
        {
            return;
        }

        Instantiate(explosion, transform.position, transform.rotation);

        if (other.tag == "Player")
        {

            Instantiate(playerExplosion, transform.position, transform.rotation);
            FindObjectOfType<GameController>().GameOver(); //expensive because it has to iterate through all the objects in the scene. 
                                     
        }
        Destroy(other.gameObject);
        Destroy(gameObject); //marks the object to be destroyed 
        

    }
}
