using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundImpact : MonoBehaviour
{
    AudioSource son;
    // Start is called before the first frame update
    void Start()
    {
      son = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
      son.Play();
    }
}
