using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Suggest : MonoBehaviour
{
    public TMP_Text tmp;
    int r;

    private void Start()
    {
        r = Random.Range(0, 5);
        StartCoroutine(LoadingText_a());
    }

    IEnumerator LoadingText_a()
    {
        yield return new WaitForSeconds(3f);

        if (r == 0)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "뿌 링 클";
        }

        if (r == 1)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "맛 초 킹";
        }

        if (r == 2)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "골 드 킹";
        }

        if (r == 3)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "자메이카 통다리";
        }

        if (r == 4)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "황금 올리브";
        }

        yield return null;
    }
}
