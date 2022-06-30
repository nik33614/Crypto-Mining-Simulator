using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Buy_Graphic : MonoBehaviour
{
    public int What_Buy;
    public int cost;
    public GameObject Button;
    public GameObject Text;

    public void Buy()
    {
        if (PlayerPrefs.GetInt("dollars") >= cost && PlayerPrefs.GetInt("Motherboard") > PlayerPrefs.GetInt("Graphic") && PlayerPrefs.GetInt("Power") > PlayerPrefs.GetInt("Graphic"))
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
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Graphic.php", form);

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
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") +0.02f);
                    break;

                case 2:
                    PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") -0.02f + 0.05f);
                    break;

                case 3:
                    if (PlayerPrefs.GetInt("Graphic") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.02f + 0.68f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.05f + 0.68f);
                    }
                    break;

                case 4:
                    if (PlayerPrefs.GetInt("Graphic") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.02f + 1.65f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.05f + 1.65f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 3)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.68f + 1.65f);
                    }
                    break;

                case 5:
                    if (PlayerPrefs.GetInt("Graphic") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.02f + 2.28f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.05f + 2.28f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 3)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.68f + 2.28f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 4)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 1.65f + 2.28f);
                    }
                    break;

                case 6:
                    if (PlayerPrefs.GetInt("Graphic") == 1)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.02f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 2)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.05f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 3)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 0.68f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 4)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 1.65f + 5.20f);
                    }
                    if (PlayerPrefs.GetInt("Graphic") == 5)
                    {
                        PlayerPrefs.SetFloat("profit", PlayerPrefs.GetFloat("profit") - 2.28f + 5.20f);
                    }
                    break;

            }
            PlayerPrefs.SetInt("Graphic", What_Buy);
            //затухающая анимация

            yield break;
        }
    }
}
