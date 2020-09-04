using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSound : MonoBehaviour
{
    AudioSource sonCris;
    float currentTime;
    public float startTime = 10f;
    bool sonJouer = false;
    // Start is called before the first frame update
    void Start()
    {
        sonCris = GetComponent<AudioSource>();
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);
        if (sonJouer == false)
        {
            if (currentTime < 0)
            {
                sonCris.Play();
                Debug.Log("Son lancer !");
                sonJouer = true;

            }

        }
    }
}
