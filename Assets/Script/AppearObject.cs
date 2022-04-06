using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearObject : MonoBehaviour
{
    [SerializeField]
    GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(wall, transform.position += new Vector3(0, 0, 10), transform.rotation);
        }
    }
}
