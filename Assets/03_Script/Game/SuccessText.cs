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
        tmp.text = "��޼���!\r\n�ֹ��޴��� .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . .";
        yield return new WaitForSeconds(0.2f);
        tmp.text = "��޼���!\r\n�ֹ��޴��� . . .";
    }
}
