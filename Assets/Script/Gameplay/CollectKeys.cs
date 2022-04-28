using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectKeys : MonoBehaviour
{
    
    private int keycollect = 0;

    private UiGame uiGame;

    private void Awake()
    {
        uiGame = GameObject.FindObjectOfType<UiGame>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            Debug.Log("collision");
            Destroy(collision.gameObject);
            keycollect++;
            uiGame.UpdateScore(keycollect);
        }
        if (collision.gameObject.CompareTag("Door"))
        {
            collision.gameObject.SetActive(false);
 
        }
    }

}
