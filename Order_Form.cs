using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Order_Form : MonoBehaviour
{
    int rate;
    public Text Price_Share;
    int old_rate;
    float timer = 0;
    public Slider Slider_;
    public Text Should_Pay;
    int to_pay;
    public Text num;

    void Start()
    {
        Slider_.maxValue = Slider_.maxValue = PlayerPrefs.GetInt("dollars")/PlayerPrefs.GetInt("price_share");
    }

    void FixedUpdate()//получаем каждые 5 секунд цену акции больше - зеленая меньше - красная. цена для всех одинакова
   {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Get_Rate();
            timer = 5f;
        }
   }

   public void Get_Rate()
   {
        old_rate = rate;
        StartCoroutine(Rate());
   }
    public IEnumerator Rate()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//возвращение курса

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            rate = Convert.ToInt32(www.text);
            if(rate > old_rate)
            {
                //запустить анимку
            }
            if(rate< old_rate)
            {
                //запустить другую анимку
            }
            PlayerPrefs.SetInt("price_share", rate);
            yield break;

        }
    }
    public void Exchange()
    {
        Slider_.maxValue = PlayerPrefs.GetInt("dollars") / PlayerPrefs.GetInt("price_share");
        Should_Pay.text = Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share").ToString() + " $";
        to_pay = Convert.ToInt32(Math.Round(Slider_.value, 0))* PlayerPrefs.GetInt("price_share");
        num.text = Slider_.value.ToString();
    }
    public void Buy()
    {
        if(PlayerPrefs.GetInt("dollars")>=(Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share"))
        {
            StartCoroutine(buy());
        }
    }
    public IEnumerator buy()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("amount", (Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share"));
        form.AddField("num", Slider_.value.ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//возвращение курса

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            
            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            yield break;

        }
    }
    public void Sell()
    {
        StartCoroutine(sell());
    }
    public IEnumerator sell()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("amount", (Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share"));
        form.AddField("num", Slider_.value.ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//возвращение курса

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            yield break;

        }//а есали нет???
    }
}
