using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SendEmail : MonoBehaviour
{
    private string username;
    private string email;
    private string url = "http://www.doublenikmak.ru/Users/GetEmail.php";
    private string code;
    public GameObject PanelEm;
    public Text Inputfield;

    void Start()
    {
        
        if (PlayerPrefs.GetInt("TutorialEmail") == 0)
        {
            if (PlayerPrefs.GetInt("code") == 0)
            {
                int Randomem = Random.Range(1000000, 9999999);
                PlayerPrefs.SetInt("code", Randomem);
            }
            PanelEm.SetActive(true);
        }


    }

    public void Email()
    {
        email = Inputfield.text;
        //PlayerPrefs.SetString("email", email);
    }

    public void Send()
    {
        StartCoroutine(Connect());
    }

    private IEnumerator Connect()
    {
        WWWForm form = new WWWForm();

        form.AddField("username", PlayerPrefs.GetString("name"));
        form.AddField("email", email);
        form.AddField("code", PlayerPrefs.GetInt("code"));

        WWW www = new WWW(url, form);
        yield return www;
        Debug.Log(www.text);

        if (www.isDone)
        {
            Debug.Log("Ok");
        }

        else
        {
            Debug.Log(www.text);
        }
        PlayerPrefs.SetInt("TutorialEmail", 1);
        PanelEm.SetActive(false);
    }
}