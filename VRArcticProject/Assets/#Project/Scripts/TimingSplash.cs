using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimingSplash : MonoBehaviour
{
    public Animator anim;
    float currentTime;
    float currentTime2;
    public float startTime = 2f;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyRootOnload(gameObject);
        currentTime = startTime;
        currentTime2 = 1f;
    }
    void DontDestroyRootOnload(GameObject obj)
    {
        DontDestroyOnLoad(obj.transform.root.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);
        if (currentTime < 0)
        {

            anim.SetBool("fadein", true);
            currentTime2 -= 1 * Time.deltaTime;
            if (currentTime2 < 0)
            {
                SceneManager.LoadScene(sceneName);
                
            }




        }
    }
}
