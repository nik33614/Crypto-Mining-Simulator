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

    public void Buy()
    {
        if(PlayerPrefs.GetInt("dollars")>= cost && PlayerPrefs.GetInt("Motherboard")>PlayerPrefs.GetInt("Cpu")&& PlayerPrefs.GetInt("Power") > PlayerPrefs.GetInt("Cpu"))
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
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Cpu.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
           
            PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(www.text));
            switch (What_Buy)
            {
                case 1:
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") + 0.01f);
                break;

                case 2:
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit")-0.01f + 0.04f);
                    break;

                case 3:
                    if (PlayerPrefs.GetInt("Cpu") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.41f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 0.41f);
                    }
                    break;

                case 4:
                    if (PlayerPrefs.GetInt("Cpu") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.71f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 0.71f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 3)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.41f + 0.71f);
                    }
                    break;

                case 5:
                    if (PlayerPrefs.GetInt("Cpu") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 0.97f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 0.97f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 3)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.41f + 0.97f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 4)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.71f + 0.97f);
                    }
                    
                    break;

                case 6:
                    if (PlayerPrefs.GetInt("Cpu") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.01f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.04f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 3)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.41f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 4)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.71f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Cpu") == 4)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.97f + 5.20f);
                    }
                    break;
                    PlayerPrefs.SetInt("Cpu", What_Buy);
            }
            //затухающая анимация

            yield break;
        }
    }
}
