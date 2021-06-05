using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Balance_Dollars : MonoBehaviour
{
    int money;
    public UnityEngine.UI.Text ScoresText;
    string a;

    void Update()
    {
       money = PlayerPrefs.GetInt("balancedollars");
        a = money.ToString();
        a = a + " $";
        ScoresText.text = a;
    }
}
