using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject manager;
    void Start()
    {
        manager = GameObject.Find("GameManager");
    }

    public void Success()
    {
        manager.GetComponent<GameManager>().Score = manager.GetComponent<GameManager>().Score + 1;
    }
}