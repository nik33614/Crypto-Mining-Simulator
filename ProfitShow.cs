using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProfitShow : MonoBehaviour
{
    float profit;
    public UnityEngine.UI.Text ScoresText;

    void Update()
    {
        profit = PlayerPrefs.GetFloat("profit");
        string a = Math.Round(profit, 4).ToString();


        a = a + " Đ/tap";

        ScoresText.text = a;

    }
}
