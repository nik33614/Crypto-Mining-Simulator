using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class BuyHouse : MonoBehaviour
{
    public int Cost;
    public string House;
    public int scene;
    public GameObject Max;
    public GameObject Panel;
    public string Ourhouse;

    public void BuySth()
    {
        PlayerPrefs.SetInt("Alwaysone", 1);
        if (PlayerPrefs.GetInt(Ourhouse) == 1)
        {
            int money = PlayerPrefs.GetInt("balancedollars");
            if (money >= Cost)
            {
                PlayerPrefs.SetInt(House, 1);
                PlayerPrefs.SetInt("balancedollars", money - Cost);
                PlayerPrefs.SetFloat("profitsec", 0);
                PlayerPrefs.SetInt("fanupgrade", 0);
                PlayerPrefs.SetInt("costfanupgrade", 0);
                PlayerPrefs.SetInt("fan_timer", 7200);
                PlayerPrefs.SetInt("Check_House", 0);
                PlayerPrefs.SetInt("pc1",0);
                int house_time_int = PlayerPrefs.GetInt("house_time");
                double time_double_new = DateTime.Now.Subtract(new DateTime(2021, 3, 4)).TotalSeconds;
                int time_new = Convert.ToInt32(Math.Round(time_double_new, 0));
                int house_time = time_new - house_time_int;


                
                PlayerPrefs.SetInt("house_time", time_new);
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
    void Update()
    {
        if (PlayerPrefs.GetInt(House) == 1)
        {
            Max.SetActive(true);
        }
    }
}