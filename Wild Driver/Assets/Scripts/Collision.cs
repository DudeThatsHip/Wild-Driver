using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] float destroyDelay = 0.5f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        // if (the thing we trigger is the package)
        // {
        //      then print "package picked up" to the console
        // }
        
        if (other.tag == "Enemy" )
        {
            Debug.Log("You Hit Something!");
            Destroy(other.gameObject, destroyDelay);
        }
    }

}
