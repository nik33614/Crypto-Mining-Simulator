using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Get_bit : MonoBehaviour
{
    int balance;
    int code;
    float bit;
    float timer = 1f;

    void Update()
    {
        timer -= Time.deltaTime;

        Click();
    }
    
    public void Click()
    {
        if (timer <= 0)
        {
            timer = 1f;
            StartCoroutine(Send());
        }
    }

    private IEnumerator Send()
    {

        code = PlayerPrefs.GetInt("code");
        balance = PlayerPrefs.GetInt("balancedollars");
        bit = PlayerPrefs.GetFloat("balance");



        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("balance", balance);
        form.AddField("bitcoin", Math.Round(bit, 4).ToString());
        WWW www = new WWW("http://doublenikmak.ru/Get_Money_Bit.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            yield break;
        }
    }
}
