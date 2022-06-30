using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Up_Panel : MonoBehaviour
{
    public Text Dollars;
    public Text Bitcoins;
    public Text Profit;

    void Update()
    {
        Dollars.text = PlayerPrefs.GetInt("dollars").ToString();
        Bitcoins.text = PlayerPrefs.GetFloat("bitcoin").ToString();
        Profit.text = PlayerPrefs.GetFloat("Profit").ToString();
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
