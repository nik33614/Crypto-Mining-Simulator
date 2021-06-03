using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Buy : MonoBehaviour
{
    public int Cost;
    public string PC;
    string PCProfitSec = "profitsec";
    public float PCProfitSecInt;
    public int scene;

    public void BuyComputer()
    {
        int money = PlayerPrefs.GetInt("balancedollars");
        if(money >= Cost)
        {
            PlayerPrefs.SetInt(PC, 1);
            PlayerPrefs.SetInt("balancedollars", money - Cost);
            PlayerPrefs.SetFloat(PCProfitSec, PCProfitSecInt);
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }
}
