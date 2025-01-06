using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suggest : MonoBehaviour
{
    public List<GameObject> list;
    public int count = 200;


    private float GetRandomNum()
    {
        Vector2 basePosition = transform.position;

        float x = Random.Range(-1800 / 2f, 1800 / 2f);

        return x;
    }
}
