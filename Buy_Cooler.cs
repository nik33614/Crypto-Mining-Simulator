using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Buy_Cooler : MonoBehaviour
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
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Cooling.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("cooling", What_Buy);
            switch (What_Buy)
            {
                case 1:
                    PlayerPrefs.SetInt("Cooler_Time", 2);
                    break;
                case 2:
                    PlayerPrefs.SetInt("Cooler_Time", 4);
                    break;
                case 3:
                    PlayerPrefs.SetInt("Cooler_Time", 6);
                    break;
                case 4:
                    PlayerPrefs.SetInt("Cooler_Time", 8);
                    break;
                case 5:
                    PlayerPrefs.SetInt("Cooler_Time", 10);
                    break;
                case 6:
                    PlayerPrefs.SetInt("Cooler_Time", 12);
                    break;
            }

            //затухающая анимация

            yield break;
        }
    }
}
