using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearObject : MonoBehaviour
{
    [SerializeField]
    GameObject gameObject;

    [SerializeField]
    float x, y, z;

    GameObject clone;

    bool done = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentLevel.contactLever == true && done == false)
        {
            clone = (GameObject)Instantiate(gameObject, transform.position += new Vector3(0, 0, 0), transform.rotation);
            done = true;
        }
        if (CurrentLevel.contactLever == false && done == true)
        {
            Destroy(clone);
            done = false;
        }
    }
}
