using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    float timer = 0f;
    float time = 0f;
    float timer_active = 15f;
    public Image Load_Image;
    float profit;
    float num;
    float fill;
    float num_prof;
    float num_max;
    float while_working;

    void Start()
    {
        StartCoroutine(Start_Time());
    }

    void FixedUpdate()
    {
       
        timer_active -= Time.deltaTime;
        timer -= Time.deltaTime;
        time -= Time.deltaTime;

        if (timer_active <= 0f)
        {
            StartCoroutine(Data_Time());
            timer_active = 3f;
        }

        if (timer < 0f)
        { 
            profit = Random.Range((float)(PlayerPrefs.GetFloat("profit") - PlayerPrefs.GetFloat("profit") * 0.4), (float)(PlayerPrefs.GetFloat("profit") + PlayerPrefs.GetFloat("profit") * 0.4));
            num_max = PlayerPrefs.GetFloat("profit") * 2;
            num = profit / num_max;
            timer = 3f;
        }
        float g = num - fill;
        fill = Load_Image.fillAmount;
        num_prof = fill + g * 0.008f;
        if (PlayerPrefs.GetFloat("profit") == 0)
        {
            fill = 0;
            num_prof = 0;
        }
        PlayerPrefs.SetFloat("profit_num", num_prof * num_max);
        Load_Image.fillAmount = num_prof;

        if (time < 0f)
        {
            if (num_prof * num_max > PlayerPrefs.GetFloat("profit") * 2)
            {
                PlayerPrefs.SetFloat("bitcoin", PlayerPrefs.GetFloat("bitcoin") + PlayerPrefs.GetFloat("profit") * 2);
                while_working = while_working + PlayerPrefs.GetFloat("profit") * 2;
            }
            else
            {
                PlayerPrefs.SetFloat("bitcoin", PlayerPrefs.GetFloat("bitcoin") + num_prof * num_max);
                while_working = while_working + num_prof * num_max;
            }
            time = 1f;
        }
    }

    public void Click()
    {
        profit = num_max;
        num = profit / num_max;
        timer = 1f;
    }

    public IEnumerator Start_Time()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Start_Time.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            PlayerPrefs.SetFloat("bitcoin", float.Parse(www.text));
            yield break;
        }
    }
    public IEnumerator Data_Time()//отправка времени
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("bit",while_working.ToString());
        WWW www = new WWW("https://doublenikmak.ru/4.0/Load_Time.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            PlayerPrefs.SetInt("dollars", int.Parse(www.text));
            while_working = 0;
        }
        yield break;
    }
}