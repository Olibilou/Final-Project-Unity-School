using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitAnimation;
     void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject animation = Instantiate(hitAnimation, transform.position, Quaternion.identity);
        Destroy(animation, 5f);
        Destroy(gameObject);
    }

}
