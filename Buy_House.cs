using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Buy_House : MonoBehaviour
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
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_House.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("background", Convert.ToInt32(www.text));

            //затухающая анимация

            yield break;
        }
    }
    
}
