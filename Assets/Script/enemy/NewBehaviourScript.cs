using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    public float min = 2f;
    public float max = 3f;

    bool detect = false;



    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + 3;

    }

    // Update is called once per frame
    void Update()
    {
        


        if(detect == false)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
        }
        if(detect == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, 4f * Time.deltaTime);
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            detect = true;
            //transform.position = Vector2.MoveTowards(transform.position, target.position, 4f * Time.deltaTime);
        }
    }
    


}
