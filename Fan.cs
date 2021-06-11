using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Cooler : MonoBehaviour
{
    float profitsec;
    long currenttime;
    double time_double_old;
    double time_double_new;
    float alltime_float;
    int time_old;
    int time_new;
    int alltime;
    int cost;
    float timer = 1f;
    public UnityEngine.UI.Text Text;
    public GameObject Panel;

    void Start()
    {
        if(PlayerPrefs.GetInt("tutorialfan") == 0)
        {
            PlayerPrefs.SetInt("fan_timer", 7200);
            PlayerPrefs.SetInt("tutorialfan", 1);
        }
    }

    void Update()
    {
        timer -= Time.deltaTime;

        Plus();
        int pc1 = PlayerPrefs.GetInt("pc1");
        int pc2 = PlayerPrefs.GetInt("pc2");
        int pc3 = PlayerPrefs.GetInt("pc3");
        int pc4 = PlayerPrefs.GetInt("pc4");
        int pc5 = PlayerPrefs.GetInt("pc5");
        int pc6 = PlayerPrefs.GetInt("pc6");
        int pc7 = PlayerPrefs.GetInt("pc7");
        int pc8 = PlayerPrefs.GetInt("pc8");
        int pc9 = PlayerPrefs.GetInt("pc9");
        int pc10 = PlayerPrefs.GetInt("pc10");
        int pc11 = PlayerPrefs.GetInt("pc11");
        int pc12 = PlayerPrefs.GetInt("pc12");
        int pc13 = PlayerPrefs.GetInt("pc13");
        int pc14 = PlayerPrefs.GetInt("pc14");
        int pc15 = PlayerPrefs.GetInt("pc15");
        int pc16 = PlayerPrefs.GetInt("pc16");
        int pc17 = PlayerPrefs.GetInt("pc17");
        int pc18 = PlayerPrefs.GetInt("pc18");
        int pc19 = PlayerPrefs.GetInt("pc19");
        int pc20 = PlayerPrefs.GetInt("pc20");

        if(pc1 == 1)
        {// обнуление в покупке дома а также сохранение на сервер
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 48);
            }
        }
        if(pc2 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 728);
            }
        }
        if(pc3 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 4106);
            }
        }
        if(pc4 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 50636);
            }
        }
        if(pc5 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 328220);
            }
        }
        if(pc6 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 144);
            }   
        }
        if(pc7 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 2184);
            }
        }
        if(pc8 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 12318);
            }
        }
        if(pc9 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 151908);
            }
        }
        if(pc10 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 984660);
            }
        }
        if(pc11 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 288);
            }
        }
        if(pc12 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 4296);
            }
        }
        if(pc13 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 24636);
            }
        }
        if(pc14 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 303816);
            }
        }
        if(pc15 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 1969320);
            }
        }
        if(pc16 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 480);
            }
        }
        if(pc17 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 7280);
            }
        }
        if(pc18 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 41060);
            }
        }
        if(pc19 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 506360);
            }   
        }
        if(pc20 == 1)
        {
            if(PlayerPrefs.GetInt("fanupgrade") == 0)
            {
                PlayerPrefs.SetInt("costfanupgrade", 0);
            }
            if(PlayerPrefs.GetInt("fanupgrade") == 1)
            {
                PlayerPrefs.SetInt("costfanupgrade", 3282200);
            }
        }
        Text = PlayerPrefs.GetInt("costfanupgrade").ToString();

    }

    public void Plus()
    {
        if (timer <= 0)
        {
            

            time_old = PlayerPrefs.GetInt("time1");
            time_double_new = DateTime.Now.Subtract(new DateTime(2021, 3, 4)).TotalSeconds;
            time_new = Convert.ToInt32(Math.Round(time_double_new, 0));
            alltime = time_new - time_old;
            if(alltime <= PlayerPrefs.GetInt("fan_timer"))
            {
                timer = 1f;
                
                //animation
            }
            else
            {
                float profitold = PlayerPrefs.GetFloat("profitsec");
                PlayerPrefs.SetFloat("profitsec",0)
                PlayerPrefs.SetFloat("profitold", profitold);
                timer = 0f;
            }

        }
    }
    public void Click()
    {
        PlayerPrefs.SetInt("time1", time_new);
        PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitold"));
    }
    public void Buy()
    {
        int balance = PlayerPrefs.GetInt("balancedollars");
        cost = PlayerPrefs.GetInt("costfanupgrade");
        if(balance >= cost)
        {
            
            PlayerPrefs.SetInt("fanupgrade", PlayerPrefs.GetInt("fanupgrade") + 1);
            PlayerPrefs.SetInt("fan_timer", PlayerPrefs.GetInt("fan_timer")+3600);
            PlayerPrefs.SetInt("costfanupgrade", PlayerPrefs.GetInt("costfanupgrade")*2);
        }
        else
        {
            Panel.SetActive(true);
        }
    }
}
//сделать сохранение на сервере номера прокачки, баланса и прокачки, профитолд