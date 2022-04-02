using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Have : MonoBehaviour {

	string money = "";
    string course_get;
    string course;
    string money_dollars_str;
    int course_int = 1000;
    int money_exchange;
    int money_dollars;
    int balance_dollars;
    float balance_coin;
    double Coin_Exchange;


    public InputField Field;
    public UnityEngine.UI.Text CourseText;
    public UnityEngine.UI.Text DollarsText;
    public int scene;

    public void Exchange()
	{
		money = Field.text;
        Coin_Exchange = Convert.ToDouble(money);
        money_exchange = Convert.ToInt32(Math.Round(Coin_Exchange, 0));
        
    }

    void Update()
    {
        money_dollars = PlayerPrefs.GetInt("course") * money_exchange;
        money_dollars_str = money_dollars.ToString() + " $";
        DollarsText.text = money_dollars_str;
    }

    void Start()
    {
        StartCoroutine(PostCourse());
    }

    private IEnumerator PostCourse()
    {
        WWWForm form = new WWWForm();
        form.AddField("Course", "Course");


        WWW www = new WWW("http://doublenikmak.ru/OpenCourse.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }

        else
        {
            //course_get = (www.text);"1 Đ = " + 
            
            PlayerPrefs.SetInt("course", Int32.Parse(www.text));
            course_int = PlayerPrefs.GetInt("course");
            CourseText.text = "1 ₿ = " + course_int + " $";
        }
    }

    public void Change()
    {
        balance_coin = PlayerPrefs.GetFloat("balance");
        balance_dollars = PlayerPrefs.GetInt("balancedollars");
        if(balance_coin >= (float)Coin_Exchange && money_exchange >= 0 && money_dollars >=0)
        {
            PlayerPrefs.SetFloat("balance", balance_coin - (float)Coin_Exchange);

            PlayerPrefs.SetInt("balancedollars", balance_dollars + money_dollars);
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }

}
