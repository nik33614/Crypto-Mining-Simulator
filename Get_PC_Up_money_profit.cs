using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Get_PC_Up_money_profit : MonoBehaviour
{
    string name;
    float profit;
    int code;
    int balance;
    int pc = 0;
    int house = 0;
    int cpu;
    int power;
    int motherboard;
    int graphic;

    public void click()
    {
        
            StartCoroutine(Send());
            
    }

    private IEnumerator Send()
    {

        code = PlayerPrefs.GetInt("code");
        profit = PlayerPrefs.GetFloat("profitsec");
        balance = PlayerPrefs.GetInt("balancedollars");

        int pc1 = PlayerPrefs.GetInt("pc1");
        int pc2 = PlayerPrefs.GetInt("pc2");
        int pc3 = PlayerPrefs.GetInt("pc3");
        int pc4 = PlayerPrefs.GetInt("pc4");
        int pc5 = PlayerPrefs.GetInt("pc5");
        int pc6 = PlayerPrefs.GetInt("pc6");
        int pc7 = PlayerPrefs.GetInt("pc7");
        int pc8 = PlayerPrefs.GetInt("pc8");
        int pc9 = PlayerPrefs.GetInt("pc9");
        int pc10 = PlayerPrefs.GetInt("pc10");
        int pc11 = PlayerPrefs.GetInt("pc11");
        int pc12 = PlayerPrefs.GetInt("pc12");
        int pc13 = PlayerPrefs.GetInt("pc13");
        int pc14 = PlayerPrefs.GetInt("pc14");
        int pc15 = PlayerPrefs.GetInt("pc15");
        int pc16 = PlayerPrefs.GetInt("pc16");
        int pc17 = PlayerPrefs.GetInt("pc17");
        int pc18 = PlayerPrefs.GetInt("pc18");
        int pc19 = PlayerPrefs.GetInt("pc19");
        int pc20 = PlayerPrefs.GetInt("pc20");

        if (pc1 == 1)
        {
            pc = 1;
        }
        if (pc2 == 1)
        {
            pc = 2;
        }
        if (pc3 == 1)
        {
            pc = 3;
        }
        if (pc4 == 1)
        {
            pc = 4;
        }
        if (pc5 == 1)
        {
            pc = 5;
        }
        if (pc6 == 1)
        {
            pc = 6;
        }
        if (pc7 == 1)
        {
            pc = 7;
        }
        if (pc8 == 1)
        {
            pc = 8;
        }
        if (pc9 == 1)
        {
            pc = 9;
        }
        if (pc10 == 1)
        {
            pc = 10;
        }
        if (pc11 == 1)
        {
            pc = 11;
        }
        if (pc12 == 1)
        {
            pc = 12;
        }
        if (pc13 == 1)
        {
            pc = 13;
        }
        if (pc14 == 1)
        {
            pc = 14;
        }
        if (pc15 == 1)
        {
            pc = 15;
        }
        if (pc16 == 1)
        {
            pc = 16;
        }
        if (pc17 == 1)
        {
            pc = 17;
        }
        if (pc18 == 1)
        {
            pc = 18;
        }
        if (pc19 == 1)
        {
            pc = 19;
        }
        if (pc20 == 1)
        {
            pc = 20;
        }

        int house1 = PlayerPrefs.GetInt("house1");
        int house2 = PlayerPrefs.GetInt("house2");
        int house3 = PlayerPrefs.GetInt("house3");
        if (house1 == 1)
        {
            house = 1;
        }
        if (house2 == 1)
        {
            house = 2;
        }
        if (house3 == 1)
        {
            house = 3;
        }

        string partcpu = "CPU_upgrade_PC" + pc.ToString();
        cpu = PlayerPrefs.GetInt(partcpu);

        string partmotherboard = "Mother_Board_upgrade_PC" + pc.ToString();
        motherboard = PlayerPrefs.GetInt(partmotherboard);

        string partpower = "Power_Supply_upgrade_PC" + pc.ToString();
        power = PlayerPrefs.GetInt(partpower);

        string partgraphic = "Graphic_Card_upgrade_PC" + pc.ToString();
        graphic = PlayerPrefs.GetInt(partgraphic);

        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("profit", profit.ToString());
        form.AddField("balance", balance);
        form.AddField("pc", pc);
        form.AddField("cpu", cpu);
        form.AddField("power", power);
        form.AddField("motherboard", motherboard);
        form.AddField("graphic", graphic);
        WWW www = new WWW("http://doublenikmak.ru/Get_PC_Up_money_profit.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            Debug.Log("ok");
        }
    }

}
