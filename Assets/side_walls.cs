using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class side_walls : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "ball")
        {
            GetComponent<AudioSource>().Play();
            string wallName = transform.name;
            game_stats.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBall");
        }
    }
}
