using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb2d;
    public GameObject hitAnimation;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall")){
          GameObject animation = Instantiate(hitAnimation, transform.position, Quaternion.identity);
            Destroy(animation, 1f);
            DestroySelf();
        }
        if (collision.gameObject.CompareTag("Decoration"))
        {
            GameObject animation = Instantiate(hitAnimation, transform.position, Quaternion.identity);
            Destroy(animation, 1f);
            DestroySelf();

        }

    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }

}
