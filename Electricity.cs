using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Electricity : MonoBehaviour
{
    float timer = 0f;
    public Text Electricity_Consumption;

    void Start()
    {
        StartCoroutine(Get_Time());
    }
    public IEnumerator Get_Time()
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
            PlayerPrefs.SetFloat("Electricity_debt", float.Parse(www.text));
        }
        yield break;
    }

    void FixedUpdate()
    {
        Electricity_Consumption.text = PlayerPrefs.GetInt("Consumption").ToString() + "W";
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            StartCoroutine(Get_Time());
            Electricity_();
            timer = 20f;
        }
    }
    void Electricity_()
    {
        if (PlayerPrefs.GetFloat("Electricity_debt") >= PlayerPrefs.GetInt("Consumption") * 24 * 3)
        {
            PlayerPrefs.SetInt("dangerous", 1);
            PlayerPrefs.SetFloat("profit", 0);
        }
    }
}
