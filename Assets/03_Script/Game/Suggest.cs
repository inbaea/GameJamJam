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
    public List<Image> pick_chiken;
    public List<GameObject> pick_coll;
    public List<GameObject> des;
    int r;
    int d;
    public GameObject manager;
    public GameObject successText1;
    public GameObject successText2;

    public GameObject curr_coll;
    public Image curr_chiken;

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

    public void StartGame()
    {
        del_par[d].gameObject.SetActive(false);
        del[d].gameObject.SetActive(false);
        des[d].gameObject.SetActive(false);
        StartCoroutine(GetRand());
        StartCoroutine(LoadingText_a());
    }

    public void GetScore()
    {
        StartCoroutine(LoadingText_d());
        manager.GetComponent<GameManager>().Score = manager.GetComponent<GameManager>().Score + 1;
        tmp_score.text = manager.GetComponent<GameManager>().Score.ToString();
        del_par[d].gameObject.SetActive(false);
        del[d].gameObject.SetActive(false);
        des[d].gameObject.SetActive(false);

        StartCoroutine(GetRand());
        StartCoroutine(LoadingText_a());
    }

    IEnumerator LoadingText_d()
    {
        successText1.SetActive(true);
        successText2.SetActive(true);

        successText1.GetComponent<SuccessText>().Success();

        yield return new WaitForSeconds(2.5f);

        successText1.SetActive(false);
        successText2.SetActive(false);
    }

    IEnumerator LoadingText_a()
    {
        yield return new WaitForSeconds(3f);
        del_par[d].gameObject.SetActive(true);
        del[d].gameObject.SetActive(true);
        des[d].gameObject.SetActive(true);
        if (r == 0)
        {
            tmp.text = "»Ñ ¸µ Å¬";
            pick_chiken[0].gameObject.SetActive(true);
            pick_coll[0].gameObject.SetActive(true);
            curr_chiken = pick_chiken[0];
            curr_coll = pick_coll[0];
        }

        if (r == 1)
        {
            tmp.text = "¸À ÃÊ Å·";
            pick_chiken[0].gameObject.SetActive(true);
            pick_coll[0].gameObject.SetActive(true);
            curr_chiken = pick_chiken[0];
            curr_coll = pick_coll[0];
        }

        if (r == 2)
        {
            tmp.text = "°ñ µå Å·";
            pick_chiken[0].gameObject.SetActive(true);
            pick_coll[0].gameObject.SetActive(true);
            curr_chiken = pick_chiken[0];
            curr_coll = pick_coll[0];
        }

        if (r == 3)
        {
            tmp.text = "ÀÚ¸ÞÀÌÄ« Åë´Ù¸®";
            pick_chiken[1].gameObject.SetActive(true);
            pick_coll[1].gameObject.SetActive(true);
            curr_chiken = pick_chiken[1];
            curr_coll = pick_coll[1];
        }

        if (r == 4)
        {
            tmp.text = "È²±Ý ¿Ã¸®ºê";
            pick_chiken[1].gameObject.SetActive(true);
            pick_coll[1].gameObject.SetActive(true);
            curr_chiken = pick_chiken[1];
            curr_coll = pick_coll[1];

        }

        if (r == 5)
        {
            tmp.text = "ÇÖº£ÀÌÅ©";
            pick_chiken[1].gameObject.SetActive(true);
            pick_coll[1].gameObject.SetActive(true);
            curr_chiken = pick_chiken[1];
            curr_coll = pick_coll[1];
        }

        if (r == 6)
        {
            tmp.text = "°íÃß ¹Ù»ç»è";
            pick_chiken[2].gameObject.SetActive(true);
            pick_coll[2].gameObject.SetActive(true);
            curr_chiken = pick_chiken[2];
            curr_coll = pick_coll[2];
        }
        if (r == 7)
        {
            tmp.text = "°¥ºñÃµ¿Õ";
            pick_chiken[2].gameObject.SetActive(true);
            pick_coll[2].gameObject.SetActive(true);
            curr_chiken = pick_chiken[2];
            curr_coll = pick_coll[2];
        }
        if (r == 8)
        {
            tmp.text = "º¼ÄÉÀÌ³ë";
            pick_chiken[2].gameObject.SetActive(true);
            pick_coll[2].gameObject.SetActive(true);
            curr_chiken = pick_chiken[2];
            curr_coll = pick_coll[2];
        }
        if (r == 9)
        {
            tmp.text = "¿À¸®¿£Å» ÆÄ´ß";
            pick_chiken[3].gameObject.SetActive(true);
            pick_coll[3].gameObject.SetActive(true);
            curr_chiken = pick_chiken[3];
            curr_coll = pick_coll[3];
        }
        if (r == 10)
        {
            tmp.text = "½º³ëÀ® Ä¡Å²";
            pick_chiken[3].gameObject.SetActive(true);
            pick_coll[3].gameObject.SetActive(true);
            curr_chiken = pick_chiken[3];
            curr_coll = pick_coll[3];
        }
        if (r == 11)
        {
            tmp.text = "ÇÖºí¸µ";
            pick_chiken[3].gameObject.SetActive(true);
            pick_coll[3].gameObject.SetActive(true);
            curr_chiken = pick_chiken[3];
            curr_coll = pick_coll[3];
        }
        if (r == 12)
        {
            tmp.text = "ºí·¢ ¾Ë¸®¿À";
            pick_chiken[4].gameObject.SetActive(true);
            pick_coll[4].gameObject.SetActive(true);
            curr_chiken = pick_chiken[4];
            curr_coll = pick_coll[4];
        }
        if (r == 13)
        {
            tmp.text = "ÄÜ¼Ò¸ÞÀÌÂ¡";
            pick_chiken[4].gameObject.SetActive(true);
            pick_coll[4].gameObject.SetActive(true);
            curr_chiken = pick_chiken[4];
            curr_coll = pick_coll[4];
        }
        if (r == 14)
        {
            tmp.text = "°íÃß¸¶¿ä";
            pick_chiken[4].gameObject.SetActive(true);
            pick_coll[4].gameObject.SetActive(true);
            curr_chiken = pick_chiken[4];
            curr_coll = pick_coll[4];
        }
        if (r == 15)
        {
            tmp.text = "Çã´ÏÄÞº¸";
            pick_chiken[5].gameObject.SetActive(true);
            pick_coll[5].gameObject.SetActive(true);
            curr_chiken = pick_chiken[5];
            curr_coll = pick_coll[5];
        }
        if (r == 16)
        {
            tmp.text = "·¹µåÄÞº¸";
            pick_chiken[5].gameObject.SetActive(true);
            pick_coll[5].gameObject.SetActive(true);
            curr_chiken = pick_chiken[5];
            curr_coll = pick_coll[5];
        }
        if (r == 17)
        {
            tmp.text = "¿Á¼ö¼ö ¿À¸®Áö³¯";
            pick_chiken[5].gameObject.SetActive(true);
            pick_coll[5].gameObject.SetActive(true);
            curr_chiken = pick_chiken[5];
            curr_coll = pick_coll[5];
        }
        if (r == 18)
        {
            tmp.text = "¶¥¶¥ ºÒ°¥ºñ";
            pick_chiken[6].gameObject.SetActive(true);
            pick_coll[6].gameObject.SetActive(true);
            curr_chiken = pick_chiken[6];
            curr_coll = pick_coll[6];
        }
        if (r == 19)
        {
            tmp.text = "Çãºê¼ø»ì";
            pick_chiken[6].gameObject.SetActive(true);
            pick_coll[6].gameObject.SetActive(true);
            curr_chiken = pick_chiken[6];
            curr_coll = pick_coll[6];
        }
        if (r == 20)
        {
            tmp.text = "°¥¸¯ ÀÎ´õ µö";
            pick_chiken[7].gameObject.SetActive(true);
            pick_coll[7].gameObject.SetActive(true);
            curr_chiken = pick_chiken[7];
            curr_coll = pick_coll[7];
        }
        if (r == 21)
        {
            tmp.text = "³ë¶û 3Á¾ ¼¼Æ®";
            pick_chiken[7].gameObject.SetActive(true);
            pick_coll[7].gameObject.SetActive(true);
            curr_chiken = pick_chiken[7];
            curr_coll = pick_coll[7];
        }
        if (r == 22)
        {
            tmp.text = "¾Ë½ÎÇÑ ¸¶´Ã Ä¡Å²";
            pick_chiken[7].gameObject.SetActive(true);
            pick_coll[7].gameObject.SetActive(true);
            curr_chiken = pick_chiken[7];
            curr_coll = pick_coll[7];
        }
        if (r == 23)
        {
            tmp.text = "¸Ê½¶·© Ä¡Å²";
            pick_chiken[8].gameObject.SetActive(true);
            pick_coll[8].gameObject.SetActive(true);
            curr_chiken = pick_chiken[8];
            curr_coll = pick_coll[8];
        }
        if (r == 24)
        {
            tmp.text = "¸Ê½îÀÌÅ± Ä¡Å²";
            pick_chiken[8].gameObject.SetActive(true);
            pick_coll[8].gameObject.SetActive(true);
            curr_chiken = pick_chiken[8];
            curr_coll = pick_coll[8];
        }
        if (r == 25)
        {
            tmp.text = "Çã´ÏÆË Ä¡Å²";
            pick_chiken[8].gameObject.SetActive(true);
            pick_coll[8].gameObject.SetActive(true);
            curr_chiken = pick_chiken[8];
            curr_coll = pick_coll[8];
        }
        if (r == 26)
        {
            tmp.text = "Ä¡Åä½º Ä¡Å²";
            pick_chiken[9].gameObject.SetActive(true);
            pick_coll[9].gameObject.SetActive(true);
            curr_chiken = pick_chiken[9];
            curr_coll = pick_coll[9];
        }
        if (r == 27)
        {
            tmp.text = "Ä¡ÇÊ¸µ";
            pick_chiken[9].gameObject.SetActive(true);
            pick_coll[9].gameObject.SetActive(true);
            curr_chiken = pick_chiken[9];
            curr_coll = pick_coll[9];
        }
        if (r == 28)
        {
            tmp.text = "±î¸£º¸ºÒ´ß";
            pick_chiken[9].gameObject.SetActive(true);
            pick_coll[9].gameObject.SetActive(true);
            curr_chiken = pick_chiken[9];
            curr_coll = pick_coll[9];
        }
        if (r == 29)
        {
            tmp.text = "ºò½ÎÀÌ¼ø»ì";
            pick_chiken[10].gameObject.SetActive(true);
            pick_coll[10].gameObject.SetActive(true);
            curr_chiken = pick_chiken[10];
            curr_coll = pick_coll[10];
        }
        if (r == 30)
        {
            tmp.text = "¸¾½º¾ç³ä ºò½ÎÀÌ¼ø»ì";
            pick_chiken[10].gameObject.SetActive(true);
            pick_coll[10].gameObject.SetActive(true);
            curr_chiken = pick_chiken[10];
            curr_coll = pick_coll[10];
        }
        if (r == 31)
        {
            tmp.text = "¾ç³ä±¸ÀÌ Ä¡Å²";
            pick_chiken[11].gameObject.SetActive(true);
            pick_coll[11].gameObject.SetActive(true);
            curr_chiken = pick_chiken[11];
            curr_coll = pick_coll[11];
        }
        if (r == 32)
        {
            tmp.text = "¼Ò±Ý±¸ÀÌ Ä¡Å²";
            pick_chiken[11].gameObject.SetActive(true);
            pick_coll[11].gameObject.SetActive(true);
            curr_chiken = pick_chiken[11];
            curr_coll = pick_coll[11];
        }
        if (r == 33)
        {
            tmp.text = "´©·îÁö Åë´ß";
            pick_chiken[12].gameObject.SetActive(true);
            pick_coll[12].gameObject.SetActive(true);
            curr_chiken = pick_chiken[12];
            curr_coll = pick_coll[12];
        }
        if (r == 34)
        {
            tmp.text = "±èÁ¾±¸Âý½ÒÅë´ß±¸ÀÌ";
            pick_chiken[12].gameObject.SetActive(true);
            pick_coll[12].gameObject.SetActive(true);
            curr_chiken = pick_chiken[12];
            curr_coll = pick_coll[12];
        }
        if (r == 35)
        {
            tmp.text = "½Ä¸À¶ËÁýÆ¢±è";
            pick_chiken[12].gameObject.SetActive(true);
            pick_coll[12].gameObject.SetActive(true);
            curr_chiken = pick_chiken[12];
            curr_coll = pick_coll[12];
        }

        del[d].sprite = chiken[r].sprite;
        yield return null;
    }
}
