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
            tmp.text = "�� �� Ŭ";
        }

        if (r == 1)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "�� �� ŷ";
        }

        if (r == 2)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "�� �� ŷ";
        }

        if (r == 3)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "�ڸ���ī ��ٸ�";
        }

        if (r == 4)
        {
            yield return new WaitForSeconds(1f);
            tmp.text = "Ȳ�� �ø���";
        }

        yield return null;
    }
}
