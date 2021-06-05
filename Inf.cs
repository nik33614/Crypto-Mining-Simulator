using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inf : MonoBehaviour
{
    string PC;
    string CPU;
    string motherboard;
    string powersupply;
    int code;
    string graphiccard;
    int balance;
    float balancebit;
    float profit;
    string upgrades;
    string answer;

    void Start()
    {
        if (PlayerPrefs.GetInt("TutorialEmail") != 0)
        {
            code = PlayerPrefs.GetInt("code");
            int pc1 = PlayerPrefs.GetInt("pc1");
            int pc2 = PlayerPrefs.GetInt("pc2");
            int pc3 = PlayerPrefs.GetInt("pc3");
            int pc4 = PlayerPrefs.GetInt("pc4");
            int pc5 = PlayerPrefs.GetInt("pc5");

            int cpu1 = PlayerPrefs.GetInt("CPU_upgrade_PC1");
            int cpu2 = PlayerPrefs.GetInt("CPU_upgrade_PC2");
            int cpu3 = PlayerPrefs.GetInt("CPU_upgrade_PC3");
            int cpu4 = PlayerPrefs.GetInt("CPU_upgrade_PC4");
            int cpu5 = PlayerPrefs.GetInt("CPU_upgrade_PC5");

            int motherboard1 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
            int motherboard2 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");
            int motherboard3 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");
            int motherboard4 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");
            int motherboard5 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");

            int powersupply1 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1");
            int powersupply2 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2");
            int powersupply3 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3");
            int powersupply4 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4");
            int powersupply5 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5");

            int graphiccard1 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC1");
            int graphiccard2 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC2");
            int graphiccard3 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC3");
            int graphiccard4 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC4");
            int graphiccard5 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC5");

            balance = PlayerPrefs.GetInt("balancedollars");
            balancebit = PlayerPrefs.GetFloat("balance");
            Debug.Log("check");
            profit = PlayerPrefs.GetFloat("profitsec");

            PC = pc1.ToString() + "-" + pc2.ToString() + "-" + pc3.ToString() + "-" + pc4.ToString() + "-" + pc5.ToString()+"*";
            CPU = cpu1.ToString() + "-" + cpu2.ToString() + "-" + cpu3.ToString() + "-" + cpu4.ToString() + "-" + cpu5.ToString();
            motherboard = motherboard1.ToString() + "-" + motherboard2.ToString() + "-" + motherboard3.ToString() + "-" + motherboard4.ToString() + "-" + motherboard5.ToString();
            powersupply = powersupply1.ToString() + "-" + powersupply2.ToString() + "-" + powersupply3.ToString() + "-" + powersupply4.ToString() + "-" + powersupply5.ToString();
            graphiccard = graphiccard1.ToString() + "-" + graphiccard2.ToString() + "-" + graphiccard3.ToString() + "-" + graphiccard4.ToString() + "-" + graphiccard5.ToString();

            upgrades = "CPU " + CPU + " motherboard " + motherboard + " powersupply " + powersupply + " graphiccard " + graphiccard + "*";

            StartCoroutine(SendInformation());
        }
    }

    private IEnumerator SendInformation()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        form.AddField("code", code.ToString());
        form.AddField("pc", PC);
        form.AddField("upgrades", upgrades);
        form.AddField("money", balance.ToString() + "*");
        form.AddField("bitcoin", balancebit.ToString() + "*");
        form.AddField("profit", profit.ToString());



        WWW www = new WWW("http://doublenikmak.ru/Users/AddUser.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("Произошла ошибка: " + www.error);
            yield break;


        }

        else
        {
            answer = www.text;
        }
    }
}
