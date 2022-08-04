using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Buy_MotherBoard : MonoBehaviour
{
    public int What_Buy;
    public int cost;
    public GameObject Button;
    public GameObject Text;

    void Start()
    {

        if (PlayerPrefs.GetInt("Motherboard") >= What_Buy)
        {
            Text.SetActive(false);
            Button.SetActive(false);
        }

    }
    public void Buy()
    {
        if (PlayerPrefs.GetInt("dollars") >= cost)
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
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Motherboard.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("Motherboard", What_Buy);
            Debug.Log(PlayerPrefs.GetInt("code").ToString());
            Text.GetComponent<Animator>().enabled = true;
            Button.GetComponent<Animator>().enabled = true;

            yield break;
        }
    }
}