using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Suggest : MonoBehaviour
{
    public TMP_Text tmp;
    public TMP_Text tmp_score;
    public List<Image> del;
    public List<Image> del_par;
    public List<Image> chiken;
    int r;
    int d;
    public GameObject manager;

    private void Start()
    {
        StartCoroutine(GetRand());
        StartCoroutine(LoadingText_a());
        manager = GameObject.Find("GameManager");
    }

    IEnumerator GetRand()
    {
        r = Random.Range(0, 36);
        d = Random.Range(0, 8);

        yield return null;
    }

    public void GetScore()
    {
        manager.GetComponent<GameManager>().Score = manager.GetComponent<GameManager>().Score + 1;
        tmp_score.text = manager.GetComponent<GameManager>().Score.ToString();
        del_par[d].gameObject.SetActive(false);
        del[d].gameObject.SetActive(false);

        StartCoroutine(GetRand());
        StartCoroutine(LoadingText_a());
    }

    IEnumerator LoadingText_a()
    {
        yield return new WaitForSeconds(3f);
        del_par[d].gameObject.SetActive(true);
        del[d].gameObject.SetActive(true);
        if (r == 0)
        {
            tmp.text = "�� �� Ŭ";
        }

        if (r == 1)
        {
            tmp.text = "�� �� ŷ";
        }

        if (r == 2)
        {
            tmp.text = "�� �� ŷ";
        }

        if (r == 3)
        {
            tmp.text = "�ڸ���ī ��ٸ�";
        }

        if (r == 4)
        {
            tmp.text = "Ȳ�� �ø���";
            
        }

        if (r == 5)
        {
            tmp.text = "�ֺ���ũ";
        }

        if (r == 6)
        {
            tmp.text = "���� �ٻ��";
        }
        if (r == 7)
        {
            tmp.text = "����õ��";
        }
        if (r == 8)
        {
            tmp.text = "�����̳�";
        }
        if (r == 9)
        {
            tmp.text = "������Ż �Ĵ�";
        }
        if (r == 10)
        {
            tmp.text = "������ ġŲ";
        }
        if (r == 11)
        {
            tmp.text = "�ֺ�";
        }
        if (r == 12)
        {
            tmp.text = "�� �˸���";
        }
        if (r == 13)
        {
            tmp.text = "�ܼҸ���¡";
        }
        if (r == 14)
        {
            tmp.text = "���߸���";
        }
        if (r == 15)
        {
            tmp.text = "����޺�";
        }
        if (r == 16)
        {
            tmp.text = "�����޺�";
        }
        if (r == 17)
        {
            tmp.text = "������ ��������";
        }
        if (r == 18)
        {
            tmp.text = "���� �Ұ���";
        }
        if (r == 19)
        {
            tmp.text = "������";
        }
        if (r == 20)
        {
            tmp.text = "���� �δ� ��";
        }
        if (r == 21)
        {
            tmp.text = "��� 3�� ��Ʈ";
        }
        if (r == 22)
        {
            tmp.text = "�˽��� ���� ġŲ";
        }
        if (r == 23)
        {
            tmp.text = "�ʽ��� ġŲ";
        }
        if (r == 24)
        {
            tmp.text = "�ʽ���ű ġŲ";
        }
        if (r == 25)
        {
            tmp.text = "����� ġŲ";
        }
        if (r == 26)
        {
            tmp.text = "ġ�佺 ġŲ";
        }
        if (r == 27)
        {
            tmp.text = "ġ�ʸ�";
        }
        if (r == 28)
        {
            tmp.text = "����Ҵ�";
        }
        if (r == 29)
        {
            tmp.text = "����̼���";
        }
        if (r == 30)
        {
            tmp.text = "������� ����̼���";
        }
        if (r == 31)
        {
            tmp.text = "��䱸�� ġŲ";
        }
        if (r == 32)
        {
            tmp.text = "�ұݱ��� ġŲ";
        }
        if (r == 33)
        {
            tmp.text = "������ ���";
        }
        if (r == 34)
        {
            tmp.text = "������������߱���";
        }
        if (r == 35)
        {
            tmp.text = "�ĸ�����Ƣ��";
        }

        del[d].sprite = chiken[r].sprite;
        yield return null;
    }
}
