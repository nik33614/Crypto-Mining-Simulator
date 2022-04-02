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
    float money;
    string answer;
    public UnityEngine.UI.Text PlaceText;
    int tutorial;
    public Text Inputfield;
    public int scene;
    public GameObject Panel;
    public Text text;
    private string url = "http://www.doublenikmak.ru/Users/GetEmail.php";
    int y = 0;


     void Start()
     {
        PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
        
        if (PlayerPrefs.GetInt("Tutorial") == 1)
        {
            StartCoroutine(Send());
        }
        if(PlayerPrefs.GetInt("Tutorial") == 0 && PlayerPrefs.GetInt("pc1") == 0)
        {
            PlayerPrefs.SetFloat("timerad", 9999);
            PlayerPrefs.SetFloat("balance", 100f);
            Panel.SetActive(true);
            PlayerPrefs.SetInt("check_y", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Tutorial", 1);
        }
        
     }
   
    public void CheckString()
    {
        name = Inputfield.text;
       // PlayerPrefs.SetString("name", name);
        
    }
     public void Check()
     {
        
        StartCoroutine(Checks());
     }
    private IEnumerator Send()
    {
        tutorial = PlayerPrefs.GetInt("Tutorial");
        name  = PlayerPrefs.GetString("name");
        string u = Math.Round(PlayerPrefs.GetFloat("profit_information"), 4).ToString();
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("money", u);
        form.AddField("tutorial", tutorial);
       
        WWW www = new WWW("http://doublenikmak.ru/Leaderboard/Leaderboard_.php", form);

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
                yield break;
            }
            else
            {
                PlayerPrefs.SetInt("Tutorial", 1);
                PlayerPrefs.SetString("name", name);
                
                if (answer == "")
                {
                    PlayerPrefs.SetInt("Leaderboard", 2890); // can not convert null
                    PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
                }
                else
                {
                    PlayerPrefs.SetInt("Leaderboard", Convert.ToInt32(answer)); // can not convert null
                    PlaceText.text = PlayerPrefs.GetInt("Leaderboard").ToString();
                    yield break;
                }
            }
        }
    }

    private IEnumerator Checks()
    {
        //name = PlayerPrefs.GetString("name");
        WWWForm form = new WWWForm();
        //Debug.Log(name);
        form.AddField("name", name);
        
        text.text = "Wait...";
        WWW www = new WWW("http://doublenikmak.ru/find_user.php", form);

        yield return www;
        Debug.Log(www.text);
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            answer = www.text;
            if (answer == "True")
            {
                text.text = "This name is already exsisted";
                yield break;
            }
            else
            {
                text.text = "Done";
                PlayerPrefs.SetFloat("timerad", 28);
                PlayerPrefs.SetInt("Tutorial", 1);
                PlayerPrefs.SetString("name", name);
                
                
                StartCoroutine(Connect());
                
                SceneManager.LoadScene(scene);

            }
        }
    }
    private IEnumerator Connect()
    {
        y = PlayerPrefs.GetInt("check_y");
        y += 1;
        PlayerPrefs.SetInt("check_y", y);
        if(y == 1)
        {
            WWWForm form = new WWWForm();

            form.AddField("username", PlayerPrefs.GetString("name"));
            form.AddField("email", "null");
            form.AddField("code", PlayerPrefs.GetInt("code"));

            WWW www = new WWW(url, form);
            yield return www;
        

            if (www.isDone)
            {
                yield break;
            }

            else
            {
                Debug.Log(www.text);
                yield break;
            }
            PlayerPrefs.SetInt("TutorialEmail", 1);
            SceneManager.LoadScene(scene);
        }
        //PanelEm.SetActive(false);
    }
}
