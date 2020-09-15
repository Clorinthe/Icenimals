using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSound : MonoBehaviour
{

    private Collider sphereCollider;
    public GameObject suite = null;
    public GameObject pet = null;
    public GameObject pet2 = null;
    bool fin = false;
    bool insphere = false;
    AudioSource sonCris;
    float currentTime;
    public float startTime = 10f;
    bool sonJouer = false;
    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        sonCris = GetComponent<AudioSource>();
        currentTime = startTime;
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);

        if (sonJouer == false)
        {
            sonCris.Play();
            sonJouer = true;
        }
        if (currentTime < 0)
        {

            if (!insphere)
            {
                Debug.Log("tkt, sa passe !");
                suite.SetActive(true);
                pet2.SetActive(true);
                pet.SetActive(false);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            insphere = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            insphere = false;
        }
    }

}
