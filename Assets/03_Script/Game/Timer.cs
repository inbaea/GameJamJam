using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text tmp;
    public float time;
    public GameObject player;
    public GameObject restart;
    public GameObject manager;

    public TMP_Text score;
    public TMP_Text record;

    private void Awake()
    {
        time = 155f;
        player = GameObject.Find("Player");
    }

    public void StartTime()
    {
        time = 155f;
    }

    private void Update()
    {
        if (time > 0)
            time -= Time.deltaTime;

        tmp.text = Mathf.Ceil(time).ToString();

        if (time <= 0)
        {
            time = 0;
            tmp.text = "0";
            player.GetComponent<PlayerMove>().CanMove = false;
            player.GetComponent<PlayerMove>().inputVec.x = 0;
            player.GetComponent<PlayerMove>().inputVec.y = 0;
            restart.SetActive(true);
            score.text = manager.GetComponent<GameManager>().Score.ToString();
            record.text = manager.GetComponent<GameManager>().Record.ToString();
        }
    }
}
