using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeSound1 : MonoBehaviour
{
    
    public GameObject pet = null;
    bool fin = false;
    AudioSource sonCris;
    float currentTime;
    public float startTime = 10f;
    bool sonJouer = false;
    // Start is called before the first frame update
    void Start()
    {
        sonCris = GetComponent<AudioSource>();
        currentTime = startTime;
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
       

        if (sonJouer == false)
        {
            sonCris.Play();
            sonJouer = true;
        }
        if (currentTime < 0)
        {
            SceneManager.LoadScene("#1");

        }

    }
}
