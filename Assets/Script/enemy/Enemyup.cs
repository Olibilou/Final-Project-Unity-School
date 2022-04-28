using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyup : MonoBehaviour
{
    [SerializeField]
    private Transform target;


    private float min;
    private float max;

    [SerializeField]
    private float distance;

    bool detect = false;

    [SerializeField]
    private float speed;



    // Use this for initialization
    void Start()
    {

        min = transform.position.y;
        max = transform.position.y + distance;

    }

    // Update is called once per frame
    void Update()
    {

        //Mathf.PingPong(Time.time * speed, max - min) + min

        if (detect == false)
        {
            transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, max - min) + min, transform.position.z);
        }
        if (detect == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
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
