using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class ProfitInformation : MonoBehaviour
{
    float timer = 10f;
    public UnityEngine.UI.Text CourseText;

    void Update()
    {
        timer -= Time.deltaTime;
        Plus();
    }

    public void Plus()
    {
        if (timer <= 0)
        {
            timer = 10f;
            StartCoroutine(PostCourse());

        }
    }

    private IEnumerator PostCourse()
    {
        string g = PlayerPrefs.GetFloat("profit_information").ToString();
        WWWForm form = new WWWForm();
        form.AddField("Profit", g);

        WWW www = new WWW("http://doublenikmak.ru/OpenProfit.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }

        else
        {
            
            PlayerPrefs.SetInt("information", Int32.Parse(www.text));
            
            int h = PlayerPrefs.GetInt("information");
            string o = h.ToString();
            CourseText.text = o + " $";
        }
    }
}