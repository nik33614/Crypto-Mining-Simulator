using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BanInfo : MonoBehaviour
{
    int code;
    public int level;
    
    string answer;

    void Start()
    {
        StartCoroutine(Ban());
        
        
    }

    private IEnumerator Ban()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        form.AddField("code", code.ToString());


        WWW www = new WWW("http://doublenikmak.ru/Users/Ban.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("Произошла ошибка: " + www.error);
            yield break;


        }

        else
        {
            answer = www.text;
            PlayerPrefs.SetInt("ban", Convert.ToInt32(answer));


            Debug.Log(www.text);

        }

        if (PlayerPrefs.GetInt("ban") == 2 && PlayerPrefs.GetInt("TutorialEmail") != 0)
        {
            
                Application.LoadLevel(level);
            
                
            
        }
        if (PlayerPrefs.GetInt("ban") == 3)
        {
            Application.LoadLevel(33);
        }

    }
}