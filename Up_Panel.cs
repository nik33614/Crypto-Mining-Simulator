using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Up_Panel : MonoBehaviour
{
    public Text Dollars;
    public Text Bitcoins;
    public Text Profit;

    void Update()
    {
        if (PlayerPrefs.GetInt("dollars") < 1000)
        {
            Dollars.text = PlayerPrefs.GetInt("dollars").ToString();
        }
        if (PlayerPrefs.GetInt("dollars") > 999 && PlayerPrefs.GetInt("dollars") < 1000000)
        {
            Dollars.text = (Math.Round((float)PlayerPrefs.GetInt("dollars") / 1000, 2).ToString() + "k").Replace(",", ".");
        }
        if (PlayerPrefs.GetInt("dollars") > 999999 && PlayerPrefs.GetInt("dollars") < 1000000000)
        {
            Dollars.text = (Math.Round((float)PlayerPrefs.GetInt("dollars") / 1000000, 2).ToString() + "m").Replace(",", ".");
        }
        if (PlayerPrefs.GetInt("dollars") > 999999999)
        {
            Dollars.text = (Math.Round((float)PlayerPrefs.GetInt("dollars") / 1000000000, 2).ToString() + "t").Replace(",", ".");
        }


        if (PlayerPrefs.GetFloat("bitcoin") < 1000)
        {
            Bitcoins.text = PlayerPrefs.GetFloat("bitcoin").ToString();
        }
        if (PlayerPrefs.GetFloat("bitcoin") > 999 && PlayerPrefs.GetFloat("bitcoin") < 1000000)
        {
            Bitcoins.text = (Math.Round((float)PlayerPrefs.GetFloat("bitcoin") / 1000, 2).ToString() + "k").Replace(",", ".");
        }
        if (PlayerPrefs.GetFloat("bitcoin") > 999999 && PlayerPrefs.GetFloat("bitcoin") < 1000000000)
        {
            Bitcoins.text = (Math.Round((float)PlayerPrefs.GetFloat("bitcoin") / 1000000, 2).ToString() + "m").Replace(",", ".");
        }
        if (PlayerPrefs.GetFloat("bitcoin") > 999999999)
        {
            Bitcoins.text = (Math.Round((float)PlayerPrefs.GetFloat("bitcoin") / 1000000000, 2).ToString() + "t").Replace(",", ".");
        }


        Profit.text = Math.Round(PlayerPrefs.GetFloat("profit_num"), 2).ToString();
        //Bitcoins.text = PlayerPrefs.GetFloat("bitcoin").ToString();
        //Profit.text = PlayerPrefs.GetFloat("Profit").ToString();
    }
    public void Daily_Present()
    {

    }
    public void Dangerous_Inf()
    {

    }
    public void Mail()
    {

    }
    public void IAP()
    {

    }
}
