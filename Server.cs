using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Server : MonoBehaviour
{
	string name ;
    int money;
    string answer;
    public UnityEngine.UI.Text PlaceText;
    int tutorial;
    public Text Inputfield;
    public int scene;
    public GameObject Panel;
    public Text text;

    void Start()
    {
        //PlayerPrefs.SetString("name", "");
       // PlayerPrefs.SetInt("Tutorial", 0);
        if (PlayerPrefs.GetInt("Tutorial") == 1)
        {
            StartCoroutine(Send());
        }
        else
        {
            Panel.SetActive(true);
        }
        
    }
   
    public void CheckString()
    {
        name = Inputfield.text;
        
        
    }

    public void Check()
    {
        PlayerPrefs.SetString("name", name);
        StartCoroutine(Checks());
    }

    private IEnumerator Send()
    {
        tutorial = PlayerPrefs.GetInt("Tutorial");
        name  = PlayerPrefs.GetString("name");
        money = PlayerPrefs.GetInt("balancedollars");
	balance = PlayerPrefs.GetFloat("balance");
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("money", money);
        form.AddField("tutorial", tutorial);
	form.AddField("bit", balance);
        WWW www = new WWW("http://doublenikmak.ru/Leaderboard/Leaderboard.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            answer = www.text;
            if(answer == "True" && tutorial == 0)
            {
                Debug.Log("This name is already exsisted");
            }
            else
            {
                PlayerPrefs.SetInt("Tutorial", 1);
                PlayerPrefs.SetString("name", name);
                //Debug.Log(answer);
                if (answer == "")
                {
                    PlayerPrefs.SetInt("Leaderboard", 75); // can not convert null
                    PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
                }
                else
                {
                    PlayerPrefs.SetInt("Leaderboard", Convert.ToInt32(answer)); // can not convert null
                    PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
                }
            }
        }
    }

    private IEnumerator Checks()
    {
        tutorial = PlayerPrefs.GetInt("Tutorial");
        name = PlayerPrefs.GetString("name");
        money = PlayerPrefs.GetInt("balancedollars");
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("money", money);
        form.AddField("tutorial", tutorial);
        WWW www = new WWW("http://doublenikmak.ru/Leaderboard/Leaderboard.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            answer = www.text;
            if (answer == "True" && tutorial == 0)
            {
                text.text = "This name is already exsisted";
                //Debug.Log("This name is already exsisted");
            }
            else
            {
                PlayerPrefs.SetInt("Tutorial", 1);
                PlayerPrefs.SetString("name", name);
                //Debug.Log(answer);
                if(answer == "")
                {
                    PlayerPrefs.SetInt("Leaderboard", 75); // can not convert null
                    PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
                }
                else
                {
                    PlayerPrefs.SetInt("Leaderboard", Convert.ToInt32(answer));
                    PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
                }
                

                SceneManager.LoadScene(scene);

            }
        }
    }
}
