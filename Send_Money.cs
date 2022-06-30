using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Send_Money : MonoBehaviour
{
    public Text Card_number;
    string number;
    public Slider Slider_;
    public Text Send;
    private float send_mon;
    public Text Error;

    void Start()
    {
        Slider_.maxValue = PlayerPrefs.GetInt("dollars");
        Slider_.value = Convert.ToInt32(Math.Round((float)PlayerPrefs.GetInt("dollars") / 2, 0).ToString());
    }

    public void Get_Number()
    {
        number = (Card_number.text).Replace(" ", "");
    }
    public void Get_Amount()
    {
        send_mon = Slider_.value;
        Send.text = send_mon.ToString();
    }
    public void Send_()
    {
        if (PlayerPrefs.GetInt("dollars") >= Convert.ToInt32(send_mon))
        {
            StartCoroutine(Send_Money_());
        }
        else
        {
            Error.text = "Not enought money";
        }
    }
    public IEnumerator Send_Money_()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("card", number);
        form.AddField("amount", Convert.ToInt32(send_mon.ToString()));
        WWW www = new WWW("https://doublenikmak.ru/4.0/Send_Money.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            if (www.text != "1")
            {
                //Error.text = www.text;
                Error.text = "Card doesn't exist";
            }
            else
            {
                Error.text = "Done!";
                PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(send_mon));
            }
            yield break;
        }
    }
}
