using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
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

    [SerializeField]
    private int health;

    public GameObject hitAnimation;







    // Use this for initialization
    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + distance;

    }

    // Update is called once per frame
    void Update()
    {
        


        if(detect == false)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * speed, max - min) + min, transform.position.y, transform.position.z);
        }
        if(detect == true)
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

        if (collision.CompareTag("Bullet")) 
        {
            health--;
            GameObject animation = Instantiate(hitAnimation, transform.position, Quaternion.identity);
            Destroy(animation, 1f);
            Destroy(collision.gameObject);
            if(health <= 0)
            {
                Destroy(gameObject);
            }
        }


    }
    


}
