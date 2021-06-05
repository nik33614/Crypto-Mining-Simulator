using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Balance : MonoBehaviour
{
    float money;
    public UnityEngine.UI.Text ScoresText;

    void Update()
    {
        money = PlayerPrefs.GetFloat("balance");
        string a = Math.Round(money, 4).ToString();
        

        a = a + " ₿";

        ScoresText.text = a;

    }
}