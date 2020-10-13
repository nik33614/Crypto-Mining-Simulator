using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBuyCh2 : MonoBehaviour
{
    int gravityupgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {



        gravityupgrade = PlayerPrefs.GetInt("gravityupgrade2");
        cost = PlayerPrefs.GetInt("costgravityupgrade2");
        balance = PlayerPrefs.GetInt("money");
        timer = PlayerPrefs.GetFloat("gravity2");

        if (balance >= cost)
        {

            balance -= cost;
            timer += 0.1f;
            gravityupgrade += 1;

            PlayerPrefs.SetInt("gravityupgrade2", gravityupgrade);
            PlayerPrefs.SetInt("money", balance);
            PlayerPrefs.SetFloat("gravity2", timer);


        }
        else
        {

            panel.SetActive(true);

        }

    }
}
