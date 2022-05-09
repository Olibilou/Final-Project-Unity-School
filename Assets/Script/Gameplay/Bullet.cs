using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed;
    private float direction;
    private bool hit;
    Rigidbody2D rb2d;
    public GameObject hitAnimation;
    private BoxCollider2D boxCollider;


    private void Awake()
    {
        
    }
    private void Update()
    {
       // if (hit) return;
       // float movementSpeed - speed * Time.deltaTime * direction;
       // Transform.Transalate(movementSpeed, 0, 0);
    }


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
  //  public void SetDirection(float _direction)
  //  {
    //    direction = _direction;
   //     gameObject.SetActive(true);
   //     hit = false;

    //    float localScaleX = transform.localScale.x;
    //    if (Mathf.Sign(localScaleX) != _direction)
    //        localScaleX = -localScaleX;

   //     transform.localScale = new Vector3(localScaleX, transform.localScale.y, transform.localScale.z);

   // }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }

}
