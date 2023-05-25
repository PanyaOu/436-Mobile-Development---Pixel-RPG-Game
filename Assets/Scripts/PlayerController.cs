using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MovementJoystick movementJoystick;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(movementJoystick.joystickVector.y != 0){
            rb.velocity = new Vector2(movementJoystick.joystickVector.x * moveSpeed, movementJoystick.joystickVector.y * moveSpeed);
        }
        else{
            rb.velocity = Vector2.zero;
        }
    }
}
