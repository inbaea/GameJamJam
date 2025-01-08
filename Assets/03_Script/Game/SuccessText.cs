using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SuccessText : MonoBehaviour
{
    public TMP_Text tmp;

    public void Success()
    {
        StartCoroutine(LoadingText_c());
    }

    IEnumerator LoadingText_c()
    {
        tmp.text = "배달성공!\r\n주문받는중 .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "배달성공!\r\n주문받는중 . . .";
    }
}
