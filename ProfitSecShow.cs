using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProfitSecShow : MonoBehaviour
{
    float profit;
    public UnityEngine.UI.Text ScoresText;

    void Update()
    {
        profit = PlayerPrefs.GetFloat("profitsec");
        string a = Math.Round(profit, 4).ToString();


        a = a + " ₿/sec";

        ScoresText.text = a;

    }
}
