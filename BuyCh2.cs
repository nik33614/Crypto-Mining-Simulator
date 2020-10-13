using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCh2 : MonoBehaviour
{

    int jetupgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {
        jetupgrade = PlayerPrefs.GetInt("jet2");
        cost = PlayerPrefs.GetInt("cost2");
        balance = PlayerPrefs.GetInt("money");
        timer = PlayerPrefs.GetFloat("timer2");

        if (balance>=cost)
        {
            
            balance -= cost;
            timer += 1f;
            jetupgrade += 1;

            PlayerPrefs.SetInt("jet2", jetupgrade);
            PlayerPrefs.SetInt("money", balance);
            PlayerPrefs.SetFloat("timer2", timer);

            int m = Mathf.RoundToInt(timer);
            if(m == 07)
            {
                PlayerPrefs.SetInt("07", 1);
            }
            if (m == 10)
            {
                PlayerPrefs.SetInt("010", 1);
            }
            if (m == 20)
            {
                PlayerPrefs.SetInt("020", 1);
            }

        }
        else
        {

            panel.SetActive(true);

        }
    }
}
