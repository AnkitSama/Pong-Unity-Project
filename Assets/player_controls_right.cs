using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controls_right : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;
    //start
    void start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector2(0,speed);
        }
        else if (Input.GetKey("down"))
        {
            rb.velocity = new Vector2(0,-speed);
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}
