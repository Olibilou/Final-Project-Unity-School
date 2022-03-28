using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiGame : MonoBehaviour
{
    // total key in level
    [SerializeField]
    private int keytotal;

    //the text element
    [SerializeField]
    private Text keyscore;

    private bool test = false;


    // Start is called before the first frame update
    void Start()
    {
        keyscore.text = 0 + "/" + keytotal + " keys";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int keycollect)
    {
        keyscore.text = keycollect + "/" + keytotal + " keys";
        if(keycollect == keytotal)
        {
            test = true;
        }
    }
    public bool endLevel()
    {
        return test;
    }

    
}
