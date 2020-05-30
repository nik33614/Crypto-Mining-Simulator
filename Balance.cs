using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    int money;
    public UnityEngine.UI.Text ScoresText;

    void Update()
    {
        money = PlayerPrefs.GetInt("money");

        string a = money.ToString();

        a = a + " $";

        ScoresText.text = a;
    }
}
