using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Score;
    public int Record;

    void Start()
    {
        Score = 0;
        Record = 0;
    }

    public void StartScore()
    {
        Score = 0;
    }
}
