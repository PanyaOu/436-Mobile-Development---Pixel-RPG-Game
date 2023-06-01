using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    private bool canFire = true; // Flag to control the firing

    public float fireForce = 20f;

    void Start()
    {
        InvokeRepeating("Fire", 1f, 1f); // Fire method will be called every 1 second
    }

    public void Fire()
    {
        if (canFire)
        {
            GameObject projectile = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
    }

    void Update()
    {
        // Use canFire flag to control the firing
    }

    void onCollisionEnter2D(Collision2D other)
    {
        switch(other.gameObject.tag)
        {
            case "Enemy":
                Destroy(other.gameObject);
                Destroy(gameObject);
                break;
        }
    }
}
