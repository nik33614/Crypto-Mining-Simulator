using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBuy : MonoBehaviour
{
    int jetupgrade;
    int cost;
    public UnityEngine.UI.Text ScoresText;

    void Update()
    {
        jetupgrade = PlayerPrefs.GetInt("jet");

        if(jetupgrade == 0)
        {
            cost = 6;

            

            string a = cost.ToString();

            a = a + " $";

            ScoresText.text = a;

            PlayerPrefs.SetInt("cost", cost);
        }

        else
        {
            cost = jetupgrade + 2;

            cost = cost * 13;

            string a = cost.ToString();

            a = a + " $";

            ScoresText.text = a;
            PlayerPrefs.SetInt("cost", cost);
        }
    }
}
