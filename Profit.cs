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
   // public GameObject Black;
   // public GameObject Colour;
    float colour;

    float timer = 1f;
    int are_you_okay = 0;
    int are_you_okay_ps = 0;
    int y = 0;

   // public GameObject AreYouOkay;

    void Update()
    {
        if (are_you_okay >= 35)
        {
            are_you_okay = 0;
        }
        timer -= Time.deltaTime;
        colour -= Time.deltaTime;
        Plus();
    }

    public void Plus()
    {
        if (timer <= 0)
        {
            timer = 1f;
            y += 1;
            if(are_you_okay_ps <= 3 && are_you_okay > 0 )
            {
                are_you_okay -= 3;
                are_you_okay_ps = 0;
            }
            else
            {
                are_you_okay_ps = 0;
            }

            time_old = PlayerPrefs.GetInt("time");
            time_double_new = DateTime.Now.Subtract(new DateTime(2021, 3, 4)).TotalSeconds;
            time_new = Convert.ToInt32(Math.Round(time_double_new, 0));
            PlayerPrefs.SetInt("time", time_new);
            alltime = time_new - time_old;
            if (alltime <= PlayerPrefs.GetInt("fan_timer"))
            {
                alltime_float = alltime;
                
                profitsec = PlayerPrefs.GetFloat("profitsec"); 
                float money = profitsec * alltime_float;
                float balance = PlayerPrefs.GetFloat("balance");
                PlayerPrefs.SetFloat("balance", money + balance);
                PlayerPrefs.SetFloat("profit_information", money + PlayerPrefs.GetFloat("profit_information"));
            }
            else
            {
                
                float time_fan = PlayerPrefs.GetInt("fan_timer");
                profitsec = PlayerPrefs.GetFloat("profitsec"); 
                float money = profitsec * time_fan;
                float balance = PlayerPrefs.GetFloat("balance");
                PlayerPrefs.SetFloat("balance", money + balance);
                PlayerPrefs.SetFloat("profit_information", money + PlayerPrefs.GetFloat("profit_information"));
                PlayerPrefs.SetFloat("profitsec", 0);
            }
            
        }
        if(colour <= 0)
        {
            //Black.SetActive(true);
            //Colour.SetActive(false);
        }
        if (y == 2)
        {

            StartCoroutine(PostCourse());
        }
    }

    public void Tap()
    {
        //Black.SetActive(false);
        //Colour.SetActive(true);
        colour = 1f;
        are_you_okay += 1;
        are_you_okay_ps += 1;
        //Debug.Log(are_you_okay);
        
            

        PlayerPrefs.SetFloat("balance", (PlayerPrefs.GetFloat("profitsec"))/2 + PlayerPrefs.GetFloat("balance"));
    }

    private IEnumerator PostCourse()
    {
        y = 0;
        WWWForm form = new WWWForm();
        form.AddField("Profit", Math.Round(PlayerPrefs.GetFloat("profit_information"), 4).ToString());
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("http://doublenikmak.ru/OpenProfit.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }

        else
        {
            
            yield break;
        }
    }

}