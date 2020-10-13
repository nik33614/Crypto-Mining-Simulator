using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFuelCh1 : MonoBehaviour
{
    int co2upgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {
        
       
        
            co2upgrade = PlayerPrefs.GetInt("runupgrade1");
            cost = PlayerPrefs.GetInt("costrunupgrade1");
            balance = PlayerPrefs.GetInt("money");
            timer = PlayerPrefs.GetFloat("run1");

            if (balance >= cost)
            {

                balance -= cost;
                timer += 0.03f;
                co2upgrade += 1;

                PlayerPrefs.SetInt("runupgrade1", co2upgrade);
                PlayerPrefs.SetInt("money", balance);
                PlayerPrefs.SetFloat("run1", timer);


            }
            else
            {

                panel.SetActive(true);

            }
        
    }
}
