using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contact1 : MonoBehaviour
{
    
    public OriginalMCBlob blob = null;
    [Range(0.0f, 2.0f)]
    public float decay_speed = 1.0f;

    private OriginalMCBlobSource src = null;
    private bool is_touched = false;

    public bool dying = false;

    void Start()
    {
        src = gameObject.GetComponent<OriginalMCBlobSource>();
    }

    //Ce script sert à détruire les objets qui génère le blob.
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.tag == "Player")
        {
            is_touched = true;
            //if (blob != null)
            //{
            //    blob.deleteSources(gameObject);
            //}
            //Destroy(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            is_touched = false;
        }
    }

    void Update()
    {
        if (src == null) {
            return;
        }
        if (is_touched || dying) { 
            if (src.power > 0)
            {
                src.power = Mathf.Max(0, src.power - decay_speed * Time.deltaTime);
            }
            else if(src.power == 0) {
                if (blob != null)
                {
                    blob.deleteSources(gameObject);
                }
                Destroy(gameObject);
            }
        }

    }

}
