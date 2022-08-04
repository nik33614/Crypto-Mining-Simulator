using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Buy_Cpu : MonoBehaviour
{
    public int What_Buy;
    public int cost;
    public GameObject Button;
    public GameObject Text;
    float profit = 0f;

    void Start()
    {
        
        if(PlayerPrefs.GetInt("Cpu")>=What_Buy)
        {
            Text.SetActive(false);
            Button.SetActive(false);
        }
        
    }

    public void Buy()
    {
        if(PlayerPrefs.GetInt("dollars")>= cost && PlayerPrefs.GetInt("Motherboard")>PlayerPrefs.GetInt("Cpu")&& PlayerPrefs.GetInt("Power") > PlayerPrefs.GetInt("Cpu"))
        {
            
            StartCoroutine(Send_Money_());
        }
        else
        {
            GameObject.Find("IAP_Panel").SetActive(true);
        }
    }

    public IEnumerator Send_Money_()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("buy", What_Buy);
        form.AddField("cost", cost);
        
        switch (What_Buy)
        {
            case 1:
                PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") + 0.01f);
                profit = 0.01f;
                break;

            case 2:
                PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.04f);
                profit = 0.03f;
                break;

            case 3:
                if (PlayerPrefs.GetInt("Cpu") == 1)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.41f);
                    profit = 0.40f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 2)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 0.41f);
                    profit = 0.37f;
                }
                break;

            case 4:
                if (PlayerPrefs.GetInt("Cpu") == 1)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.71f);
                    profit = 0.70f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 2)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 0.71f);
                    profit = 0.67f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 3)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.41f + 0.71f);
                    profit = 0.30f;
                }
                break;

            case 5:
                if (PlayerPrefs.GetInt("Cpu") == 1)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.97f);
                    profit = 0.96f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 2)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 0.97f);
                    profit = 0.93f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 3)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.41f + 0.97f);
                    profit = 0.56f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 4)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.71f + 0.97f);
                    profit = 0.26f;
                }

                break;

            case 6:
                if (PlayerPrefs.GetInt("Cpu") == 1)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 5.20f);
                    profit =5.19f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 2)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 5.20f);
                    profit = 5.16f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 3)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.41f + 5.20f);
                    profit = 4.79f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 4)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.71f + 5.20f);
                    profit = 4.49f;
                }
                if (PlayerPrefs.GetInt("Cpu") == 5)
                {
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.97f + 5.20f);
                    profit = 4.23f;
                }
                break;
                
        }
       
        form.AddField("profit", profit.ToString());
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Cpu.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Text.GetComponent<Animator>().enabled = true;
            Button.GetComponent<Animator>().enabled = true;
            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("Cpu", What_Buy);
           
            yield break;
        }
    }
}
