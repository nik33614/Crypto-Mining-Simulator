using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFuelCh2 : MonoBehaviour
{
    int co2upgrade;
    int cost;
    int balance;
    float timer;
    public GameObject panel;

    public void buy()
    {
        
       
        
            co2upgrade = PlayerPrefs.GetInt("runupgrade2");
            cost = PlayerPrefs.GetInt("costrunupgrade2");
            balance = PlayerPrefs.GetInt("money");
            timer = PlayerPrefs.GetFloat("run2");
            Debug.Log(co2upgrade);
        if (balance >= cost)
        {

                balance -= cost;
                timer += 0.01f;
                co2upgrade += 1;
            Debug.Log(co2upgrade);
            PlayerPrefs.SetInt("runupgrade2", co2upgrade);
                
                PlayerPrefs.SetInt("money", balance);
                PlayerPrefs.SetFloat("run2", timer);


        }
        else
        {

                panel.SetActive(true);

        }
        
    }
}
