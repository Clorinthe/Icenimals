using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSound : MonoBehaviour
{
    public GameObject suite = null;
    public GameObject pet = null;
    public GameObject pet2 = null;
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
        Debug.Log(currentTime);

        if (sonJouer == false)
        {
            sonCris.Play();
            sonJouer = true;
        }
        if (currentTime < 0)
        {
            suite.SetActive(true);
            pet2.SetActive(true);
            pet.SetActive(false);

        }

    }
}
