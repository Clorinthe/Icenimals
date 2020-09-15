using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{
    
    float currentTime;
    public float startTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < 0)
        {
            return;
        }
        currentTime -= 1 * Time.deltaTime;
        
        if (currentTime < 0)
        {
            Debug.Log("restart");
            //SceneManager.UnloadSceneAsync("#1");
            SceneManager.LoadSceneAsync("#1");
        }
    }
    
}
