using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBuyCh1 : MonoBehaviour
{
    int gravityupgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {



        gravityupgrade = PlayerPrefs.GetInt("gravityupgrade1");
        cost = PlayerPrefs.GetInt("costgravityupgrade1");
        balance = PlayerPrefs.GetInt("money");
        timer = PlayerPrefs.GetFloat("gravity1");

        if (balance >= cost)
        {

            balance -= cost;
            timer += 0.1f;
            gravityupgrade += 1;

            PlayerPrefs.SetInt("gravityupgrade1", gravityupgrade);
            PlayerPrefs.SetInt("money", balance);
            PlayerPrefs.SetFloat("gravity1", timer);


        }
        else
        {

            panel.SetActive(true);

        }

    }
}
