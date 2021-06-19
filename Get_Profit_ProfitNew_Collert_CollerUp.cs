using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Get_Profit_ProfitNew_Collert_CollerUp : MonoBehaviour
{
    int upgrade;
    int code;
    float profitnew;
    float profitold;
    int collertime;

    float timer = 3f;

    void Start()
    {
        StartCoroutine(Send());
    }

    void Update()
    {
        timer -= Time.deltaTime;

        Timen();
    }



    void Timen()
    {
        if (timer <= 0)
        {
            timer = 3f;


            StartCoroutine(Send());
        }
    }

    

    public void Click()
    {
        StartCoroutine(Send());
    }

    private IEnumerator Send()
    {

        code = PlayerPrefs.GetInt("code");
        upgrade = PlayerPrefs.GetInt("fanupgrade");
        collertime = PlayerPrefs.GetInt("fan_timer");
        profitnew = PlayerPrefs.GetFloat("profitsec");
        profitold = PlayerPrefs.GetFloat("profitold");
            



        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("fanupgrade", upgrade);
        form.AddField("fan_timer", collertime);
        form.AddField("profit", profitnew.ToString());
        form.AddField("profitold", profitold.ToString());
        WWW www = new WWW("http://doublenikmak.ru/Get_Profit_ProfitNew_Cooler.php", form);

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
