using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Choose_Walpapers : MonoBehaviour
{
    private int place;
    public GameObject Next_;
    public GameObject Back_;
    public Text Name;
    public Text Inf;
    public GameObject Choose;
    public GameObject Buy_;
    private int cost;

    public Image wallpaper;
    public Image Background;
    public Sprite Green;
    public Sprite Yellow;
    public Sprite Blue;
    public Sprite Pink;
    public Sprite Evening;
    public Sprite ban;
    public Sprite Poster;

    public void Next()
    {

        if(place >= 0)
        {
            Back_.SetActive(true);
        }
        place++;
    }

    public void Back()
    {
        if (place <= 6)
        {
            Next_.SetActive(true);
        }
        place--;
    }

    void FixedUpdate()
    {
        
        if (place >= 6)
        {
            Next_.SetActive(false);
        }
        if (place <=0)
        {
            Back_.SetActive(false);
        }
        
        switch(place)
        {
            case 0:
                Name.text = "Green Waves";
                Inf.text = "";
                wallpaper.sprite = Green;
                if (PlayerPrefs.GetInt("Wallpapers")!=0)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                else
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                break;

            case 1:
                Name.text = "Yellow Rays";
                Inf.text = "500 000$";
                wallpaper.sprite = Yellow;
                if (PlayerPrefs.GetInt("Wallpapers") != 1 && PlayerPrefs.GetInt("Wall_1") == 1)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wallpapers") == 1 && PlayerPrefs.GetInt("Wall_1") == 1)
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wall_1") == 0)
                {
                    Buy_.SetActive(true);
                    Choose.SetActive(false);
                }
                break;
            case 2:
                Name.text = "Blue Puddles";
                Inf.text = "2 000 000$";
                wallpaper.sprite = Blue;
                if (PlayerPrefs.GetInt("Wallpapers") != 2 && PlayerPrefs.GetInt("Wall_2") == 1)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wallpapers") == 2 && PlayerPrefs.GetInt("Wall_2") == 1)
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wall_2") == 0)
                {
                    Buy_.SetActive(true);
                    Choose.SetActive(false);
                }
                break;
            case 3:
                Name.text = "Pink Sunset";
                Inf.text = "Make the first purchase";
                wallpaper.sprite = Pink;
                if (PlayerPrefs.GetInt("Wallpapers") != 3 && PlayerPrefs.GetInt("Num_Bought") >= 1)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wallpapers") == 3 && PlayerPrefs.GetInt("Wall_3") == 1)
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wall_3") == 0)
                {
                    Buy_.SetActive(true);
                    Choose.SetActive(false);
                }
                break;
            case 4:
                Name.text = "Evening Mountains";
                Inf.text = "Make the second purchase";
                wallpaper.sprite = Evening;
                if (PlayerPrefs.GetInt("Wallpapers") != 4 && PlayerPrefs.GetInt("Num_Bought") >= 2)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wallpapers") == 4 && PlayerPrefs.GetInt("Wall_4") == 1)
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wall_4") == 0)
                {
                    Buy_.SetActive(true);
                    Choose.SetActive(false);
                }
                break;
            case 5:
                Name.text = "Blue Banduk";
                wallpaper.sprite = ban;
                Inf.text = "Make the third purchase";
                if (PlayerPrefs.GetInt("Wallpapers") != 5 && PlayerPrefs.GetInt("Num_Bought") >= 3)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wallpapers") == 5 && PlayerPrefs.GetInt("Wall_5") == 1)
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wall_5") == 0)
                {
                    Buy_.SetActive(true);
                    Choose.SetActive(false);
                }
                break;
            case 6:
                Name.text = "Snowy Posters";
                Inf.text = "Make the forth purchase";
                wallpaper.sprite = Poster;
                if (PlayerPrefs.GetInt("Wallpapers") != 6 && PlayerPrefs.GetInt("Num_Bought") >= 4)
                {
                    Choose.SetActive(true);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wallpapers") == 6 && PlayerPrefs.GetInt("Wall_6") == 1)
                {
                    Choose.SetActive(false);
                    Buy_.SetActive(false);
                }
                if (PlayerPrefs.GetInt("Wall_6") == 0)
                {
                    Buy_.SetActive(true);
                    Choose.SetActive(false);
                }
                break;
        }
    }
    public void Choose_()
    {
        PlayerPrefs.SetInt("Wallpapers", place);
        switch (place)
        {
            case 0:
                Background.sprite = Green;
                break;

            case 1:
                Background.sprite = Yellow;
                break;
            case 2:
                Background.sprite = Blue;
                break;
            case 3:
                Background.sprite = Pink;
                break;
            case 4:
                Background.sprite = Evening;
                break;
            case 5:
                Background.sprite = ban;
                break;
            case 6:
                Background.sprite = Poster;
                break;
        }
    }
    public void Buy()
    {
        switch (place)
        {
            case 1:
                if (PlayerPrefs.GetInt("dollars")>=500000)
                {
                    PlayerPrefs.SetInt("Wall_1", 1);
                    StartCoroutine(Buy__());
                }
                else
                {
                    GameObject.Find("IAP_Panel").SetActive(true);
                }

                break;
            case 2:
                if (PlayerPrefs.GetInt("dollars") >= 2000000)
                {
                    PlayerPrefs.SetInt("Wall_2", 1);
                    StartCoroutine(Buy__());
                }
                else
                {
                    GameObject.Find("IAP_Panel").SetActive(true);
                    
                }
                break;
            case 3:
                GameObject.Find("IAP_Panel").SetActive(true);
                break;
            case 4:
                GameObject.Find("IAP_Panel").SetActive(true);
                break;
            case 5:
                GameObject.Find("IAP_Panel").SetActive(true);
                break;
            case 6:
                GameObject.Find("IAP_Panel").SetActive(true);
                break;

        }
    }
    public IEnumerator Buy__()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        
        switch (place)
        {
            case 1:
                cost = 500000;
                break;
            case 2:
                cost = 2000000;
                break;
            case 3:
                cost = 0;
                break;
            case 4:
                cost = 0;
                break;
            case 5:
                cost = 0;
                break;
            case 6:
                cost = 0;
                break;
        }
        form.AddField("cost", cost);
        form.AddField("wall", place);
        
        WWW www = new WWW("https://doublenikmak.ru/4.0/Buy_Wall.php", form);

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
}
