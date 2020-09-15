using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suivant : MonoBehaviour
{
    public Rigidbody pet = null;
    private TimeSound suite = null;
    public GameObject sources = null;
    public int minimumSources = 5;
    public bool theEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        suite = GetComponent<TimeSound>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sources.transform.childCount < minimumSources && !theEnd)
        {
            theEnd = true;
            Contact1[] contacts = sources.GetComponentsInChildren<Contact1>();
            foreach (Contact1 c in contacts)
            {
                c.dying = true;
            }
            pet.constraints = RigidbodyConstraints.FreezePosition;
        }
        else if (sources.transform.childCount == 0)
        {
            suite.enabled = true;
        }
    }
}
