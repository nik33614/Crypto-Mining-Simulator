using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBuy : MonoBehaviour
{
    int gravityupgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {



        gravityupgrade = PlayerPrefs.GetInt("gravityupgrade");
        cost = PlayerPrefs.GetInt("costgravityupgrade");
        balance = PlayerPrefs.GetInt("money");
        timer = PlayerPrefs.GetFloat("gravity");

        if (balance >= cost)
        {

            balance -= cost;
            timer += 0.01f;
            gravityupgrade += 1;

            PlayerPrefs.SetInt("gravityupgrade", gravityupgrade);
            PlayerPrefs.SetInt("money", balance);
            PlayerPrefs.SetFloat("gravity", timer);


        }
        else
        {

            panel.SetActive(true);

        }

    }
}
