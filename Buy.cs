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
    public string OurPC;
    public GameObject Panel;
    public void BuyComputer()
    {
        PlayerPrefs.SetInt("AlwaysOne", 1);
        if(PlayerPrefs.GetInt(OurPC) == 1)
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
        else
        {
            Panel.SetActive(true);
        }
    }
}
