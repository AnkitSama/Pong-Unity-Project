using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu_contorller : MonoBehaviour
{
    // Start is called before the first frame update
    public Button playVsComputer;
    public Button playVsplayer;
    public Button rules;
    public Button quit;

    public Button goBack;
    public Button pause;


    public void Play_vs_computer()
    {
        SceneManager.LoadScene(1);
    }

    public void Play_vs_player()
    {
        SceneManager.LoadScene(2);
    }

    public void Rules()
    {
        SceneManager.LoadScene(3);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Go_Back()
    {
        SceneManager.LoadScene(0);
        game_stats.player1Score = 0;
        game_stats.player2Score = 0;
        Time.timeScale = 1;
    }

    public void Pause_Game()
    {
            if(Time.timeScale==1f)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
    }

    public void Reset_Game_vsComp()
    {
        SceneManager.LoadScene(1);
        game_stats.player1Score = 0;
        game_stats.player2Score = 0;
    }

    public void Reset_Game_vsPlayer()
    {
        SceneManager.LoadScene(2);
        game_stats.player1Score = 0;
        game_stats.player2Score = 0;
    }
}
