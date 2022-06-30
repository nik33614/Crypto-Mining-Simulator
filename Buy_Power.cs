using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Buy_Power : MonoBehaviour
{
    public int What_Buy;
    public int cost;
    public GameObject Button;
    public GameObject Text;

    public void Buy()
    {
        if (PlayerPrefs.GetInt("dollars") >= cost)
        {
            StartCoroutine(Send_Money_());
        }
    }

    public IEnumerator Send_Money_()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("buy", What_Buy);
        form.AddField("cost", cost);
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Power.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("power", What_Buy);
            switch (What_Buy)
            {
                case 1:
                    PlayerPrefs.SetInt("Consumption", 350);
                    break;
                case 2:
                    PlayerPrefs.SetInt("Consumption", 400);
                    break;
                case 3:
                    PlayerPrefs.SetInt("Consumption", 500);
                    break;
                case 4:
                    PlayerPrefs.SetInt("Consumption", 750);
                    break;
                case 5:
                    PlayerPrefs.SetInt("Consumption", 850);
                    break;
                case 6:
                    PlayerPrefs.SetInt("Consumption", 1000);
                    break;
            }
                    
            //затухающая анимация

            yield break;
        }
    }
}
