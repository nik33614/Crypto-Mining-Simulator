using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Get_Money_Bit : MonoBehaviour
{
    int code;
    float bit;

    float timer = 3f;

    void Update()
    {
        timer -= Time.deltaTime;

        Click();
    }

    
        
    void Click()
    {
        if (timer <= 0)
        {
            timer = 3f;


            StartCoroutine(Send());
        }
    }

    private IEnumerator Send()
    {

        code = PlayerPrefs.GetInt("code");

        bit = PlayerPrefs.GetFloat("balance");



        WWWForm form = new WWWForm();
        form.AddField("code", code);

        form.AddField("bitcoin", Math.Round(bit, 4).ToString());
        WWW www = new WWW("http://doublenikmak.ru/Get_Bit.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            Debug.Log("ok");
        }
    }
}
