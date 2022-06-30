using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CoolingSystem : MonoBehaviour
{
    public Text Cooler_Time_Total;
    public Text Coller_Left;
    public Image bar;
    public float fill;
    float seconds = 0;
    float timer = 0f;
    bool timer_recharge = false;

    public void Check_Time()
    {
        StartCoroutine(Data_Time());
    }
    void FixedUpdate()
    {
        Cooler_Time_Total.text = PlayerPrefs.GetInt("Cooler_Time").ToString() + "hours";
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            Check_Time();
            timer = 20f;
            
        }
        if(timer_recharge == true)
        {
            fill += 0.01f;
            if(fill >= 1)
            {
                timer_recharge = false;
                fill = 1f;
            }
            bar.fillAmount = fill;
        }
    }
    public IEnumerator Data_Time()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//получение даты и времени с определенного числа в секундах

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Coller_Left.text = www.text;
            string[] delimiterChars = { "h", "min" };
            string[] words = www.text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 1)
            {
                int a = 0;
                foreach (var word in words)
                {
                    a += 1;
                    if (a == 1)
                    {
                        seconds += float.Parse(word) * 60 * 60;
                    }
                    else
                    {
                        seconds += float.Parse(word) *60;
                    }
                }
            }
            else
            {
                foreach (var word in words)
                {

                    seconds += float.Parse(word) * 60;

                }
            }
            fill = seconds / (float.Parse(PlayerPrefs.GetInt("Cooler_Time").ToString()));
            //сколько осталось делить на сколько было
            bar.fillAmount = fill;
            if(seconds <=3600 && seconds > 0)
            {
                //высветить предупреждение
            }
            if(seconds == 0)
            {
                //остановить профит и высевтить ошибку
            }
            yield break;
           
        }
    }
    public void Continue()
    {
        StartCoroutine(Continiue_Send());
    }
    public IEnumerator Continiue_Send()//отправка на сервер информации о местном времени
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Time_Recharge.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            timer_recharge = true;
            yield break;
        }
    }
}