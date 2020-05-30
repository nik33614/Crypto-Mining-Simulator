using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{

    int jetupgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {
        jetupgrade = PlayerPrefs.GetInt("jet");
        cost = PlayerPrefs.GetInt("cost");
        balance = PlayerPrefs.GetInt("money");
        timer = PlayerPrefs.GetFloat("timer");

        if (balance>=cost)
        {
            
            balance -= cost;
            timer += 0.5f;
            jetupgrade += 1;

            PlayerPrefs.SetInt("jet", jetupgrade);
            PlayerPrefs.SetInt("money", balance);
            PlayerPrefs.SetFloat("timer", timer);

        }
        else
        {

            panel.SetActive(true);

        }
    }
}
