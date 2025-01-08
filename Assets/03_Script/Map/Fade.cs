using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public Image pannel;

    private void Start()
    {
        StartCoroutine(Fadeflow());
    }

    public void StartPannel()
    {
        StartCoroutine(Fadeflow());
    }

    IEnumerator Fadeflow()
    {
        pannel.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.8f);

        pannel.gameObject.SetActive(false);


        yield return null;
    }
}