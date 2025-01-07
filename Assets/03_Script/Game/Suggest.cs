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
        r = Random.Range(0, 5);
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
            tmp.text = "뿌 링 클";
        }

        if (r == 1)
        {
            tmp.text = "맛 초 킹";
        }

        if (r == 2)
        {
            tmp.text = "골 드 킹";
        }

        if (r == 3)
        {
            tmp.text = "자메이카 통다리";
        }

        if (r == 4)
        {
            tmp.text = "황금 올리브";
            
        }

        if (r == 5)
        {
            tmp.text = "핫베이크";
        }

        if (r == 6)
        {
            tmp.text = "고추 바사삭";
        }
        if (r == 7)
        {
            tmp.text = "갈비천왕";
        }
        if (r == 8)
        {
            tmp.text = "볼케이노";
        }
        if (r == 9)
        {
            tmp.text = "오리엔탈 파닭";
        }
        if (r == 10)
        {
            tmp.text = "스노윙 치킨";
        }
        if (r == 11)
        {
            tmp.text = "핫블링";
        }
        if (r == 12)
        {
            tmp.text = "블랙 알리오";
        }
        if (r == 13)
        {
            tmp.text = "콘소메이징";
        }
        if (r == 14)
        {
            tmp.text = "고추마요";
        }
        if (r == 15)
        {
            tmp.text = "허니콤보";
        }
        if (r == 16)
        {
            tmp.text = "레드콤보";
        }
        if (r == 17)
        {
            tmp.text = "옥수수 오리지날";
        }
        if (r == 18)
        {
            tmp.text = "땅땅 불갈비";
        }
        if (r == 19)
        {
            tmp.text = "허브순살";
        }
        if (r == 20)
        {
            tmp.text = "갈릭 인더 딥";
        }
        if (r == 21)
        {
            tmp.text = "노랑 3종 세트";
        }
        if (r == 22)
        {
            tmp.text = "알싸한 마늘 치킨";
        }
        if (r == 23)
        {
            tmp.text = "맵슐랭 치킨";
        }
        if (r == 24)
        {
            tmp.text = "맵쏘이킥 치킨";
        }
        if (r == 25)
        {
            tmp.text = "허니팝 치킨";
        }
        if (r == 26)
        {
            tmp.text = "치토스 치킨";
        }
        if (r == 27)
        {
            tmp.text = "치필링";
        }
        if (r == 28)
        {
            tmp.text = "까르보불닭";
        }
        if (r == 29)
        {
            tmp.text = "빅싸이순살";
        }
        if (r == 30)
        {
            tmp.text = "맘스양념 빅싸이순살";
        }
        if (r == 31)
        {
            tmp.text = "양념구이 치킨";
        }
        if (r == 32)
        {
            tmp.text = "소금구이 치킨";
        }
        if (r == 33)
        {
            tmp.text = "";
        }
        if (r == 34)
        {
            tmp.text = "";
        }
        if (r == 35)
        {
            tmp.text = "";
        }

        del[d].sprite = chiken[r].sprite;
        yield return null;
    }
}
