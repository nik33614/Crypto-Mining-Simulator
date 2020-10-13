using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFuel : MonoBehaviour
{
    int co2upgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {
        
       
        
            co2upgrade = PlayerPrefs.GetInt("runupgrade");
            cost = PlayerPrefs.GetInt("costrunupgrade");
            balance = PlayerPrefs.GetInt("money");
            timer = PlayerPrefs.GetFloat("run");

            if (balance >= cost)
            {

                balance -= cost;
                timer += 0.01f;
                co2upgrade += 1;

                PlayerPrefs.SetInt("runupgrade", co2upgrade);
                PlayerPrefs.SetInt("money", balance);
                PlayerPrefs.SetFloat("run", timer);


            }
            else
            {

                panel.SetActive(true);

            }
        
    }
}
