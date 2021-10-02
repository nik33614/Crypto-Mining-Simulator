using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Balance : MonoBehaviour
{
    float money;
    public UnityEngine.UI.Text ScoresText;
    float profit;
    float profit_4;
    float time = 0.001f;
    float time_sec = 1;
    void Update()
    {
        
        money = PlayerPrefs.GetFloat("balance");
        profit = PlayerPrefs.GetFloat("profitsec");
        profit_4 = profit / 1000;

        string a = Math.Round(money, 4).ToString();


        a = a + " ₿";

        ScoresText.text = a;
        time -= Time.deltaTime;
        time_sec -= Time.deltaTime;
        Plus();
    }
    void Plus()
    {
        if (time <= 0)
        {
            time = 0.001f;
        }
        if (time_sec <= 0)
        {
            time = 1f
        }
    }
}
