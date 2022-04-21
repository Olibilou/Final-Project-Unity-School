using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSystem : MonoBehaviour
{
    [SerializeField]
    GameObject wall;

    bool canpress = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canpress == true)
        {
            Instantiate(wall, transform.position += new Vector3(5, 0, 0), transform.rotation);
            Debug.Log("Press E");
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canpress = true;
            Debug.Log("collision");

        }
        
    }
}
