using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterCopie : MonoBehaviour
{
    public OriginalMCBlob source = null;



    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (source != null)
        {
            transform.position = source.barycenter;
        }
    }
}
