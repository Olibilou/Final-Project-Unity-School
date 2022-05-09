using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletSpeed = 20f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }
    void Shoot()
    {
         GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
         rb.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
       // bulletPrefab[0].transform.position = firePoint.position;
        //bulletPrefab[0].GetComponent<Bullet>().SetDirection(Mathf.Sign(transform.localScale.x));
    }
}
