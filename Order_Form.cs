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
        PlayerPrefs.SetFloat("bitcoin", 100.24f);
        Slider_.maxValue = Slider_.maxValue = PlayerPrefs.GetInt("dollars")/PlayerPrefs.GetInt("price_share");
        Slider_.value = Convert.ToInt32(Math.Round((float)PlayerPrefs.GetInt("dollars") / PlayerPrefs.GetInt("price_share") * 0.34f, 0).ToString());
        Exchange();
    }

    void FixedUpdate()
   {
        Should_Pay.text = (Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share")).ToString() + " $";
        to_pay = Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share");
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

        WWW www = new WWW("https://doublenikmak.ru/4.0/Get_Rate_Traiding.php", form);

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
                Price_Share.GetComponent<Animation>().Play("More");
                Price_Share.text = rate.ToString() + " $";
            }
            if(rate< old_rate)
            {
                Price_Share.GetComponent<Animation>().Play("Less");
                Price_Share.text = rate.ToString()+" $";
            }
            PlayerPrefs.SetInt("price_share", rate);
            yield break;

        }
    }
    public void Exchange()
    {
        Slider_.maxValue = Convert.ToInt32(PlayerPrefs.GetInt("dollars") / PlayerPrefs.GetInt("price_share"));
        Should_Pay.text = (Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share")).ToString() + " $";
        to_pay = Convert.ToInt32(Math.Round(Slider_.value, 0))* PlayerPrefs.GetInt("price_share");
        num.text = Slider_.value.ToString() + " Stocks";
    }
    public void Buy()
    {
        if(PlayerPrefs.GetInt("dollars")>=(Convert.ToInt32(Math.Round(Slider_.value, 0))) * PlayerPrefs.GetInt("price_share"))
        {
            StartCoroutine(buy());
        }
        else
        {
            GameObject.Find("IAP_Panel").SetActive(true);
            //не хватило
        }
    }
    public IEnumerator buy()//отпpавляет на сервер колличество купленных 100 000 -buy / 9 000 000 это новый курс
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("amount", (Convert.ToInt32(Math.Round(Slider_.value, 0))) * PlayerPrefs.GetInt("price_share"));
        form.AddField("num", Slider_.value.ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Traiding.php", form);//+

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            
            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("Stocks", PlayerPrefs.GetInt("Stocks") + Convert.ToInt32(Math.Round(Slider_.value, 0)));
            yield break;

        }
    }
    public void Sell()
    {
        if (PlayerPrefs.GetInt("Stocks") >= (Convert.ToInt32(Math.Round(Slider_.value, 0))))
        {
            StartCoroutine(sell());
        }
        else
        {
            GameObject.Find("IAP_Panel").SetActive(true);
            //не хватило акций
        }
    }
    public IEnumerator sell()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("amount", (Convert.ToInt32(Math.Round(Slider_.value, 0))) * PlayerPrefs.GetInt("price_share"));
        form.AddField("num", Slider_.value.ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Sell_Traiding.php", form);//+

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("dollars", Convert.ToInt32(www.text));
            PlayerPrefs.SetInt("Stocks", PlayerPrefs.GetInt("Stocks") - Convert.ToInt32(Math.Round(Slider_.value, 0)));
            PlayerPrefs.SetInt("sold_traid", PlayerPrefs.GetInt("sold_traid") + Convert.ToInt32(Math.Round(Slider_.value, 0)) * PlayerPrefs.GetInt("price_share"));
            yield break;

        }
    }
}
