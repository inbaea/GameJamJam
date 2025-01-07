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
            tmp.text = "»Ñ ¸µ Å¬";
        }

        if (r == 1)
        {
            tmp.text = "¸À ÃÊ Å·";
        }

        if (r == 2)
        {
            tmp.text = "°ñ µå Å·";
        }

        if (r == 3)
        {
            tmp.text = "ÀÚ¸ÞÀÌÄ« Åë´Ù¸®";
        }

        if (r == 4)
        {
            tmp.text = "È²±Ý ¿Ã¸®ºê";
            
        }

        if (r == 5)
        {
            tmp.text = "ÇÖº£ÀÌÅ©";
        }

        if (r == 6)
        {
            tmp.text = "°íÃß ¹Ù»ç»è";
        }
        if (r == 7)
        {
            tmp.text = "°¥ºñÃµ¿Õ";
        }
        if (r == 8)
        {
            tmp.text = "º¼ÄÉÀÌ³ë";
        }
        if (r == 9)
        {
            tmp.text = "¿À¸®¿£Å» ÆÄ´ß";
        }
        if (r == 10)
        {
            tmp.text = "½º³ëÀ® Ä¡Å²";
        }
        if (r == 11)
        {
            tmp.text = "ÇÖºí¸µ";
        }
        if (r == 12)
        {
            tmp.text = "ºí·¢ ¾Ë¸®¿À";
        }
        if (r == 13)
        {
            tmp.text = "ÄÜ¼Ò¸ÞÀÌÂ¡";
        }
        if (r == 14)
        {
            tmp.text = "°íÃß¸¶¿ä";
        }
        if (r == 15)
        {
            tmp.text = "Çã´ÏÄÞº¸";
        }
        if (r == 16)
        {
            tmp.text = "·¹µåÄÞº¸";
        }
        if (r == 17)
        {
            tmp.text = "¿Á¼ö¼ö ¿À¸®Áö³¯";
        }
        if (r == 18)
        {
            tmp.text = "¶¥¶¥ ºÒ°¥ºñ";
        }
        if (r == 19)
        {
            tmp.text = "Çãºê¼ø»ì";
        }
        if (r == 20)
        {
            tmp.text = "°¥¸¯ ÀÎ´õ µö";
        }
        if (r == 21)
        {
            tmp.text = "³ë¶û 3Á¾ ¼¼Æ®";
        }
        if (r == 22)
        {
            tmp.text = "¾Ë½ÎÇÑ ¸¶´Ã Ä¡Å²";
        }
        if (r == 23)
        {
            tmp.text = "¸Ê½¶·© Ä¡Å²";
        }
        if (r == 24)
        {
            tmp.text = "¸Ê½îÀÌÅ± Ä¡Å²";
        }
        if (r == 25)
        {
            tmp.text = "Çã´ÏÆË Ä¡Å²";
        }
        if (r == 26)
        {
            tmp.text = "Ä¡Åä½º Ä¡Å²";
        }
        if (r == 27)
        {
            tmp.text = "Ä¡ÇÊ¸µ";
        }
        if (r == 28)
        {
            tmp.text = "±î¸£º¸ºÒ´ß";
        }
        if (r == 29)
        {
            tmp.text = "ºò½ÎÀÌ¼ø»ì";
        }
        if (r == 30)
        {
            tmp.text = "¸¾½º¾ç³ä ºò½ÎÀÌ¼ø»ì";
        }
        if (r == 31)
        {
            tmp.text = "¾ç³ä±¸ÀÌ Ä¡Å²";
        }
        if (r == 32)
        {
            tmp.text = "¼Ò±Ý±¸ÀÌ Ä¡Å²";
        }
        if (r == 33)
        {
            tmp.text = "´©·îÁö Åë´ß";
        }
        if (r == 34)
        {
            tmp.text = "±èÁ¾±¸Âý½ÒÅë´ß±¸ÀÌ";
        }
        if (r == 35)
        {
            tmp.text = "½Ä¸À¶ËÁýÆ¢±è";
        }

        del[d].sprite = chiken[r].sprite;
        yield return null;
    }
}
