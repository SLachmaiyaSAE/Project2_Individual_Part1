using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject destroyHere;


    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.CompareTag("platform"))
        {
            Destroy(gameObject); 
        }
    }

}
