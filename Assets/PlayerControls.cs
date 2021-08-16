using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
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
        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0,speed);
        }
        else if (Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0,-speed);
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}
