using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public KeyCode upButton = KeyCode.W;
    public KeyCode downButton = KeyCode.S;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode rightButton = KeyCode.D;
 
    public float speed = 10.0f;
    public float yBoundary = 9.0f;
    public float xBoundary = 9.0f;
    private Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;
 
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }
 
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }
 
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }
 
        rigidBody2D.velocity = velocity;
        Vector3 position = transform.position;
 
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }
 
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }

        else if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }

        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }
 
        transform.position = position;
    }
}
