using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipLevel : MonoBehaviour
{
    int infoskip;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            infoskip = GetuseSkip();
            Debug.Log(infoskip);
            if (infoskip > 0)
            {
                useSkip();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    public void useSkip()
    {
        AllowSkipLevel.skipLevel -= 1;
    }
    public int GetuseSkip()
    {
        int number = AllowSkipLevel.skipLevel;
        return number;
    }
}
