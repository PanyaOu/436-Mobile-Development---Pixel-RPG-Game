using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;

    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
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
