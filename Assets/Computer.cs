using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles moving the computer's paddle through simple artificial intelligence.
/// </summary>
public class Computer : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D ball;
    public Rigidbody2D paddle;
    //start

    private void FixedUpdate()
    {
        // Check if the ball is moving towards the paddle (positive x velocity)
        // or away from the paddle (negative x velocity)
        if (ball.velocity.x < 0.0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (ball.position.y > paddle.position.y) {
                paddle.velocity = new Vector2(0,speed);
            } else if (ball.position.y < paddle.position.y) {
                paddle.velocity = new Vector2(0,-speed);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (paddle.position.y > 0.0f) {
                paddle.velocity = new Vector2(0,-speed);
            } else if (paddle.position.y < 0.0f) {
                paddle.velocity = new Vector2(0,speed);
            }
        }
    }

}