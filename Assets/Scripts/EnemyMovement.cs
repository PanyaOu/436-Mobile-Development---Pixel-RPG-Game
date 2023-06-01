using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; // Public reference to the player's transform
    public float speed = 3.0f; // The speed at which the enemy moves

    // Reference to the Rigidbody component
    private Rigidbody2D rb;

    void Start()
    {
        // Get reference to the Rigidbody component
        rb = GetComponent<Rigidbody2D>();

        // Find the player in the scene
        player = GameObject.FindWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        // Calculate the direction vector to the player
        Vector3 direction = (player.position - transform.position).normalized;

        // Apply a force in the direction of the player
        rb.AddForce(direction * speed);
    }



}