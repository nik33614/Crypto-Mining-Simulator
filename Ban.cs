using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ban : MonoBehaviour
{
    int code;
    string answer;
    public int check = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Bann());
        if (check == 7)
        {
            StartCoroutine(BanInfo());

            if (PlayerPrefs.GetInt("ban") == 2)
            {
                PlayerPrefs.SetInt("TutorialEmail", 0);

                Application.LoadLevel(0);
            }
            if (PlayerPrefs.GetInt("ban") == 1)
            {
                Application.LoadLevel(0);
            }
        }
        if (PlayerPrefs.GetInt("solution") == 1)
        {
            PlayerPrefs.SetFloat("balance", 0);
        }
        if (PlayerPrefs.GetInt("solution") == 2)
        {
            PlayerPrefs.SetInt("balancedollars", 0);
        }
        if (PlayerPrefs.GetInt("solution") == 3)
        {
            PlayerPrefs.SetFloat("profitsec", 0);
        }
        if (PlayerPrefs.GetInt("solution") == 4)
        {
            PlayerPrefs.SetFloat("profitsec", 0);
            PlayerPrefs.SetFloat("balance", 0);
            PlayerPrefs.SetInt("balancedollars", 0);
            PlayerPrefs.SetInt("pc1", 0);
            PlayerPrefs.SetInt("pc2", 0);
            PlayerPrefs.SetInt("pc3", 0);
            PlayerPrefs.SetInt("pc4", 0);
            PlayerPrefs.SetInt("pc5", 0);

            PlayerPrefs.SetInt("CPU_upgrade_PC1", 0);
            PlayerPrefs.SetInt("CPU_upgrade_PC2", 0);
            PlayerPrefs.SetInt("CPU_upgrade_PC3", 0);
            PlayerPrefs.SetInt("CPU_upgrade_PC4", 0);
            PlayerPrefs.SetInt("CPU_upgrade_PC5", 0);

            PlayerPrefs.SetInt("Mother_Board_upgrade_PC1", 0);
            PlayerPrefs.SetInt("Mother_Board_upgrade_PC2", 0);
            PlayerPrefs.SetInt("Mother_Board_upgrade_PC3", 0);
            PlayerPrefs.SetInt("Mother_Board_upgrade_PC4", 0);
            PlayerPrefs.SetInt("Mother_Board_upgrade_PC5", 0);

            PlayerPrefs.SetInt("Power_Supply_upgrade_PC1", 0);
            PlayerPrefs.SetInt("Power_Supply_upgrade_PC2", 0);
            PlayerPrefs.SetInt("Power_Supply_upgrade_PC3", 0);
            PlayerPrefs.SetInt("Power_Supply_upgrade_PC4", 0);
            PlayerPrefs.SetInt("Power_Supply_upgrade_PC5", 0);

            PlayerPrefs.SetInt("Graphic_Card_upgrade_PC1", 0);
            PlayerPrefs.SetInt("Graphic_Card_upgrade_PC2", 0);
            PlayerPrefs.SetInt("Graphic_Card_upgrade_PC3", 0);
            PlayerPrefs.SetInt("Graphic_Card_upgrade_PC4", 0);
            PlayerPrefs.SetInt("Graphic_Card_upgrade_PC5", 0);
        }

        


    }
    private IEnumerator Bann()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Users/Solution.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("Произошла ошибка: " + www.error);
            yield break;


        }

        else
        {
            answer = www.text;
            PlayerPrefs.SetInt("solution", Convert.ToInt32(answer));


            Debug.Log(www.text);

        }
    }

    private IEnumerator BanInfo()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        form.AddField("code", code);


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
    }
}
