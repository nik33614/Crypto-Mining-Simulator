using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Profit : MonoBehaviour
{
    float profitsec;
    long currenttime;
    double time_double_old;
    double time_double_new;
    float alltime_float;
    int time_old;
    int time_new;
    int alltime;

    float timer = 1f;

    void Update()
    {
        timer -= Time.deltaTime;

        Plus();
    }

    public void Plus()
    {
        if (timer <= 0)
        {
            timer = 1f;

            time_old = PlayerPrefs.GetInt("time");
            time_double_new = DateTime.Now.Subtract(new DateTime(2021, 3, 4)).TotalSeconds;
            time_new = Convert.ToInt32(Math.Round(time_double_new, 0));
            PlayerPrefs.SetInt("time", time_new);
            alltime = time_new - time_old;
            alltime_float = alltime;
            Debug.Log(alltime);
            profitsec = PlayerPrefs.GetFloat("profitsec"); // must be int
            float money = profitsec * alltime_float;
            float balance = PlayerPrefs.GetFloat("balance");
            PlayerPrefs.SetFloat("balance", money + balance);
            PlayerPrefs.SetFloat("profit_information", money);
        }
    }
}