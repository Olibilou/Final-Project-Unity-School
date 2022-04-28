using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorOneHit : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private BoxCollider2D boxCollider;

    private bool numberContact = false;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (numberContact == false)
            {
                spriteRenderer.color = Color.black;
                boxCollider.isTrigger = false;
            }
        }
    }
}
