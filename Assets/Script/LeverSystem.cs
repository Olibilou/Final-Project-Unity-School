using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSystem : MonoBehaviour
{

    GameObject lever;

    // Start is called before the first frame update
    void Start()
    {
        lever = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(CurrentLevel.contactLever == false)
            {
                CurrentLevel.contactLever = true;
            }
            else 
            { 
                CurrentLevel.contactLever = false;
            }

            Debug.Log(CurrentLevel.contactLever);
        }
        
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            CurrentLevel.contactLever = false;
            Debug.Log(CurrentLevel.contactLever);

        }
    }*/
}
