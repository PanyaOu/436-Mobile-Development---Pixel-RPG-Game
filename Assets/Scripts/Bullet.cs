using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    void onTriggerEnter2D(Collider2D other)
    {
        switch(other.gameObject.tag)
        {
            case "Enemy":
                Destroy(other.gameObject);
                Destroy(gameObject);
                break;
            case "Obstacle":
                Destroy(gameObject);
                break;
        }
    }

}
