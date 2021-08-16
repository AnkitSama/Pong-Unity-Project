using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_controls : MonoBehaviour
{
    float ballSpeed = 50;
    float xspeed = 4f;
    float yspeed = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter(5f));
        GoBall();
    }
    
    IEnumerator waiter(float t)
    {
        yield return new WaitForSeconds(t);
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D callInfo)
    {
        if(callInfo.collider.tag == "Player")
        {

            float randomNumber = Random.Range(0f, 1f);
            if(GetComponent<Rigidbody2D>().velocity.x<0)
            {
                xspeed = -4f;
            }
            if(GetComponent<Rigidbody2D>().velocity.y<0)
            {
                yspeed = -4f;
            }
            if(randomNumber<=0.5)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x*1.1f,GetComponent<Rigidbody2D>().velocity.y+yspeed);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x*1.1f,GetComponent<Rigidbody2D>().velocity.y+yspeed);
            }
            //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,GetComponent<Rigidbody2D>().velocity.y/2+new Vector2(0,callInfo.collider.GetComponent<Rigidbody2D>().velocity.y).y)/3;
            GetComponent<AudioSource>().pitch = Random.Range(0.8f, 1.2f); 
            GetComponent<AudioSource>().Play();
        }
    }

    void GoBall()
    {
        
        float randomNumber = Random.Range(0f, 1f);
        if(randomNumber<=0.25)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed,10));
        }
        else if(randomNumber<=0.5)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-ballSpeed,-10));
        }
        else if(randomNumber<=0.75)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed,-10));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-ballSpeed,10));
        }
        /*
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f)
                                      : Random.Range(0.5f, 1.0f);
        
        Vector2 direction = new Vector2(x, y);
        GetComponent<Rigidbody2D>().AddForce(direction * this.ballSpeed);*/
    }

    void ResetBall()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        GetComponent<Rigidbody2D>().position = new Vector2(0,0);
        StartCoroutine(waiter(2f));
        ballSpeed = 50;
        xspeed = 4f;
        yspeed = 4f;
        GoBall();
    }

    void Update()
    {
        float xVelocity = GetComponent<Rigidbody2D>().velocity.x;
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if(xVelocity<2 && xVelocity>-2 && xVelocity != 0)
        {
            if(xVelocity>0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(40,GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-40,GetComponent<Rigidbody2D>().velocity.y);
            }
        }
        if(yVelocity<2 && yVelocity>-2 && yVelocity != 0)
        {
            if(yVelocity>0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,40);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,-40);
            }
        }
    }
}
