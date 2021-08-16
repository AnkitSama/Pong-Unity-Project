using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_stats : MonoBehaviour
{
    public static int player1Score = 0;
    public static int player2Score = 0; 
    public GUISkin theSkin;
    Transform theBall;

    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("ball").transform;
    }
    // Update is called once per frame
    public static void Score(string wallName)
    {
        if(wallName == "RightWall")
        {
            player1Score += 1;
        }
        else
        {
            player2Score += 1;
        }
    }

    void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 250, 25, 100, 100), "" + player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 250, 25, 100, 100), "" + player2Score);
        
        int y = SceneManager.GetActiveScene().buildIndex;
        if(player1Score>=7 && y != 1)
        {
            SceneManager.LoadScene(4);
            player1Score = 0;
            player2Score = 0;
        }
        else if(player2Score>=7 && y != 1)
        {
            SceneManager.LoadScene(5);
            player1Score = 0;
            player2Score = 0;
        }
        else if(player1Score>=7 && y == 1)
        {
            SceneManager.LoadScene(6);
            player1Score = 0;
            player2Score = 0;
        }
        else if(player2Score>=7 && y == 1)
        {
            SceneManager.LoadScene(7);
            player1Score = 0;
            player2Score = 0;
        }
    }
}
