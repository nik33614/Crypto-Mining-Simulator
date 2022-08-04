using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Electricity_Estate_ : MonoBehaviour
{
    public Text Electricity;
    public Text Estate;

    float timer = 0;

    
    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            StartCoroutine(Data_Estate());
            //StartCoroutine(Data_Electricity());
            timer = 10f;
        }
        Electricity.text = Convert.ToInt32(PlayerPrefs.GetFloat("Electricity_debt")).ToString()+"$";
    }
    public IEnumerator Data_Estate()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Estate_Time.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Estate.text = Math.Round(float.Parse(www.text), 0).ToString() + "$";

            PlayerPrefs.SetFloat("Estate_debt", Convert.ToInt32(www.text));
            yield break;

        }
    }
    public IEnumerator Data_Electricity()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Electricity_Time.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Electricity.text = www.text;
            yield break;

        }
    }
    public void Pay_Est()
    {
        if(PlayerPrefs.GetInt("dollars")>=PlayerPrefs.GetFloat("Estate_debt"))
        {
            //PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - PlayerPrefs.GetFloat("Estate_debt"));
            StartCoroutine(Send_Est());
            PlayerPrefs.SetFloat("Estate_debt", 0);
        }
        else
        {
            GameObject.Find("IAP_Panel").SetActive(true);
        }
    }
    public void Pay_El()
    {
        if (PlayerPrefs.GetInt("dollars") >= PlayerPrefs.GetFloat("Electricity_debt"))
        {
            //PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(PlayerPrefs.GetFloat("Electricity_debt")));
            PlayerPrefs.SetFloat("Electricity_debt", 0);
            StartCoroutine(Send_El());
        }
        else
        {
            GameObject.Find("IAP_Panel").SetActive(true);
        }
    }
    public IEnumerator Send_Est()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("balance", PlayerPrefs.GetInt("dollars").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Send_Est.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Estate.text = "0$";
            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            yield break;

        }
    }
    public IEnumerator Send_El()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("balance", PlayerPrefs.GetInt("dollars").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Send_El.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Electricity.text = "0$";
            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            yield break;

        }
    }
}
