using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    private bool test;

    private UiGame uiGame;

    // Start is called before the first frame update
    void Start()
    {
        uiGame = GameObject.FindObjectOfType<UiGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //test is a bool that tell if the player have all the key to enter the next level
            test = uiGame.endLevel();
            Debug.Log("collision");
            if(test == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
