using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class StartText : MonoBehaviour
{
    public TMP_Text tmp;
    float time = 0f;
    float F_time = 1f;

    private void Start()
    {
        StartCoroutine(LoadingText_b());
    }

    public void StartText_a()
    {
        StartCoroutine(LoadingText_b());
    }


    IEnumerator LoadingText_b()
    {
        yield return new WaitForSeconds(0.1f);
        tmp.text = "3";

        time = 0f;

        while (tmp.fontSize > 10f)
        {
            time += Time.deltaTime / F_time;
            tmp.fontSize = Mathf.Lerp(200, 10, time);
            yield return null;
        }

        yield return new WaitForSeconds(0.1f);
        tmp.text = "2";
        tmp.fontSize = 200;

        time = 0f;

        while (tmp.fontSize > 10f)
        {
            time += Time.deltaTime / F_time;
            tmp.fontSize = Mathf.Lerp(200, 10, time);
            yield return null;
        }

        yield return new WaitForSeconds(0.1f);
        tmp.text = "1";
        tmp.fontSize = 200;

        time = 0f;

        while (tmp.fontSize > 10f)
        {
            time += Time.deltaTime / F_time;
            tmp.fontSize = Mathf.Lerp(200, 10, time);
            yield return null;
        }

        yield return new WaitForSeconds(0.1f);
        tmp.text = "Start!";
        tmp.fontSize = 250;
        tmp.color = new Color32(230, 0, 0, 255);

        yield return null;
    }
}
