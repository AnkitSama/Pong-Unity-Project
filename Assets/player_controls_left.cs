using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controls_left : MonoBehaviour
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
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0,speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0,-speed);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }
}
