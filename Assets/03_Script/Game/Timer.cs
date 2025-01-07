using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text tmp;
    public float time;
    public GameObject player;

    private void Awake()
    {
        time = 150f;
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if (time > 0)
            time -= Time.deltaTime;

        tmp.text = Mathf.Ceil(time).ToString();

        if (time <= 0)
        {
            player.GetComponent<PlayerMove>().CanMove = false;
        }
    }
}
