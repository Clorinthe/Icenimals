using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact1 : MonoBehaviour
{
    public OriginalMCBlob blob = null;
    //Ce script sert à détruire les objets qui génère le blob.
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        
        if (other.tag == "Player")
        {
            if (blob != null)
            {
                blob.deleteSources(gameObject);
            }
            Destroy(gameObject);
        }
    }
}
