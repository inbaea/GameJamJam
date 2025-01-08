using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    public GameObject player;
    public GameObject score;
    public GameObject time;
    public GameObject text;
    public GameObject restart;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReStartGame();
        }
    }
    public void ReStartGame()
    {
        if (score.GetComponent<GameManager>().Record < score.GetComponent<GameManager>().Score)
        {
            score.GetComponent<GameManager>().Record = score.GetComponent<GameManager>().Score;
        }
        player.GetComponent<PlayerMove>().StartPlayer();
        score.GetComponent<GameManager>().StartScore();
        score.GetComponent<Suggest>().StartGame();
        score.GetComponent<Fade>().StartPannel();
        time.GetComponent<Timer>().StartTime();
        text.GetComponent<StartText>().StartText_a();
        restart.SetActive(false);
    }
}
