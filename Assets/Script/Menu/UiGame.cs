using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiGame : MonoBehaviour
{
    // total key in level NEED TO BE CHANGE FOR EACH SCENE SO THAT THE GAME KNOW HOW MUCH KEY THE PLAYER NEED TO COLLECT
    [SerializeField]
    private int keytotal;
    //[SerializeField] private DoorActivation door;
    

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
    public void OpenDoor(int keycollect)
    {
        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Door");
     
        if (keycollect == keytotal)
        {
            foreach(GameObject go in gameObjectArray) 
            {
                go.SetActive(false);
            }
            

        }
    }
    public bool endLevel()
    {
        return test;
    }

    
}
