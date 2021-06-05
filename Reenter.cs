using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
//using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reenter : MonoBehaviour
{
    string checker;
    string answer;
    public Text Inputfield;
    int code;
    public UnityEngine.UI.Text ScoresText;

    public void Click()
    {
        PlayerPrefs.SetInt("TutorialEmail", 0);
        Application.LoadLevel(0);
    }

    public void Email()
    {
        checker = Inputfield.text;
    }

    public void Check()
    {
        StartCoroutine(ReEnter());
        Debug.Log(checker);
    }

    private IEnumerator ReEnter()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("em", checker);


        WWW www = new WWW("http://doublenikmak.ru/Users/Regular.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("Произошла ошибка: " + www.error);
            yield break;


        }

        else
        {
            answer = www.text;
            
            if(answer == "ok")
            {
                PlayerPrefs.SetInt("ban", 1);
                Application.LoadLevel(0);

            }
            else
            {
                ScoresText.text = "Try again";
            }

            Debug.Log(www.text);

        }
    }

}
