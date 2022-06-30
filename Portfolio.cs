using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portfolio : MonoBehaviour
{
    public Text Stocks;
    public Text sold_traid;
    public Text balance;

    void FixedUpdate()
    {
        Stocks.text = PlayerPrefs.GetInt("Stocks").ToString();
        sold_traid.text = PlayerPrefs.GetInt("sold_traid").ToString();
        balance.text = (PlayerPrefs.GetInt("Stocks") * PlayerPrefs.GetInt("price_share")).ToString();
    }
}
