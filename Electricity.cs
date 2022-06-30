using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Electricity : MonoBehaviour
{
    float timer = 0f;
    public Text Electricity_Consumption;

    void FixedUpdate()
    {
        Electricity_Consumption.text = PlayerPrefs.GetInt("Consumption").ToString() + "W";
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Electricity_();
            timer = 20f;
        }
    }
    void Electricity_()
    {
        PlayerPrefs.SetFloat("Electricity_debt", PlayerPrefs.GetFloat("Electricity_debt") + (float.Parse(PlayerPrefs.GetInt("Consumption").ToString())/60f*0.25f));
        if(PlayerPrefs.GetFloat("Electricity_debt") >= PlayerPrefs.GetInt("Consumption")*24*3)
        {
            //прекратить работу пк
        }

    }
}
