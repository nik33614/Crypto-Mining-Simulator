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
        StartCoroutine(Checks());
        if (PlayerPrefs.GetInt("TutorialEmail") != 0)
        {
            code = PlayerPrefs.GetInt("code");
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

            int cpu1 = PlayerPrefs.GetInt("CPU_upgrade_PC1");
            int cpu2 = PlayerPrefs.GetInt("CPU_upgrade_PC2");
            int cpu3 = PlayerPrefs.GetInt("CPU_upgrade_PC3");
            int cpu4 = PlayerPrefs.GetInt("CPU_upgrade_PC4");
            int cpu5 = PlayerPrefs.GetInt("CPU_upgrade_PC5");
            int cpu6 = PlayerPrefs.GetInt("CPU_upgrade_PC6");
            int cpu7 = PlayerPrefs.GetInt("CPU_upgrade_PC7");
            int cpu8 = PlayerPrefs.GetInt("CPU_upgrade_PC8");
            int cpu9 = PlayerPrefs.GetInt("CPU_upgrade_PC9");
            int cpu10 = PlayerPrefs.GetInt("CPU_upgrade_PC10");
            int cpu11 = PlayerPrefs.GetInt("CPU_upgrade_PC11");
            int cpu12 = PlayerPrefs.GetInt("CPU_upgrade_PC12");
            int cpu13 = PlayerPrefs.GetInt("CPU_upgrade_PC13");
            int cpu14 = PlayerPrefs.GetInt("CPU_upgrade_PC14");
            int cpu15 = PlayerPrefs.GetInt("CPU_upgrade_PC15");
            int cpu16 = PlayerPrefs.GetInt("CPU_upgrade_PC16");
            int cpu17 = PlayerPrefs.GetInt("CPU_upgrade_PC17");
            int cpu18 = PlayerPrefs.GetInt("CPU_upgrade_PC18");
            int cpu19 = PlayerPrefs.GetInt("CPU_upgrade_PC19");
            int cpu20 = PlayerPrefs.GetInt("CPU_upgrade_PC20");

            int motherboard1 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
            int motherboard2 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");
            int motherboard3 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");
            int motherboard4 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");
            int motherboard5 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");
            int motherboard6 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC6");
            int motherboard7 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC7");
            int motherboard8 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC8");
            int motherboard9 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC9");
            int motherboard10 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC10");
            int motherboard11 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC11");
            int motherboard12 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC12");
            int motherboard13 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC13");
            int motherboard14 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC14");
            int motherboard15 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC15");
            int motherboard16 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC16");
            int motherboard17 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC17");
            int motherboard18 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC18");
            int motherboard19 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC19");
            int motherboard20 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC20");

            int powersupply1 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1");
            int powersupply2 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2");
            int powersupply3 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3");
            int powersupply4 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4");
            int powersupply5 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5");
            int powersupply6 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6");
            int powersupply7 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7");
            int powersupply8 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8");
            int powersupply9 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9");
            int powersupply10 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10");
            int powersupply11 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11");
            int powersupply12 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12");
            int powersupply13 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13");
            int powersupply14 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14");
            int powersupply15 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15");
            int powersupply16 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16");
            int powersupply17 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17");
            int powersupply18 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18");
            int powersupply19 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19");
            int powersupply20 = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20");
           
            int graphiccard1 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC1");
            int graphiccard2 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC2");
            int graphiccard3 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC3");
            int graphiccard4 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC4");
            int graphiccard5 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC5");
            int graphiccard6 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC6");
            int graphiccard7 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC7");
            int graphiccard8 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC8");
            int graphiccard9 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC9");
            int graphiccard10 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC10");
            int graphiccard11 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC11");
            int graphiccard12 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC12");
            int graphiccard13 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC13");
            int graphiccard14 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC14");
            int graphiccard15 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC15");
            int graphiccard16 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC16");
            int graphiccard17 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC17");
            int graphiccard18 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC18");
            int graphiccard19 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC19");
            int graphiccard20 = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC20");

            int house1 = PlayerPrefs.GetInt("house1");
            int house2 = PlayerPrefs.GetInt("house2");
            int house3 = PlayerPrefs.GetInt("house3");

            balance = PlayerPrefs.GetInt("balancedollars");
            balancebit = PlayerPrefs.GetFloat("balance");
            Debug.Log("check");
            profit = PlayerPrefs.GetFloat("profitsec");

            PC = pc1.ToString() + "-" + pc2.ToString() + "-" + pc3.ToString() + "-" + pc4.ToString() + "-" + pc5.ToString() + "-" + pc6.ToString() + "-" + pc7.ToString() + "-" + pc8.ToString() + "-" + pc9.ToString() + "-" + pc10.ToString() + "-" + pc11.ToString() + "-" + pc12.ToString() + "-" + pc13.ToString() + "-" + pc14.ToString() + "-" + pc15.ToString() + "-" + pc16.ToString() + "-" + pc17.ToString() + "-" + pc18.ToString() + "-" + pc19.ToString() + "-" + pc20.ToString() + "*-" + house1.ToString() + "-" + house2.ToString() + "-" + house3.ToString() + "*";
            CPU = cpu1.ToString() + "-" + cpu2.ToString() + "-" + cpu3.ToString() + "-" + cpu4.ToString() + "-" + cpu5.ToString() + "-" + cpu6.ToString() + "-" + cpu7.ToString() + "-" + cpu8.ToString() + "-" + cpu9.ToString() + "-" + cpu10.ToString() + "-" + cpu11.ToString() + "-" + cpu12.ToString() + "-" + cpu13.ToString() + "-" + cpu14.ToString() + "-" + cpu15.ToString() + "-" + cpu16.ToString() + "-" + cpu17.ToString() + "-" + cpu18.ToString() + "-" + cpu19.ToString() + "-" + cpu20.ToString();
            motherboard = motherboard1.ToString() + "-" + motherboard2.ToString() + "-" + motherboard3.ToString() + "-" + motherboard4.ToString() + "-" + motherboard5.ToString() + "-" + motherboard6.ToString() + "-" + motherboard7.ToString() + "-" + motherboard8.ToString() + "-" + motherboard9.ToString() + "-" + motherboard10.ToString() + "-" + motherboard11.ToString() + "-" + motherboard12.ToString() + "-" + motherboard13.ToString() + "-" + motherboard14.ToString() + "-" + motherboard15.ToString() + "-" + motherboard16.ToString() + "-" + motherboard17.ToString() + "-" + motherboard18.ToString() + "-" + motherboard19.ToString() + "-" + motherboard20.ToString();
            powersupply = powersupply1.ToString() + "-" + powersupply2.ToString() + "-" + powersupply3.ToString() + "-" + powersupply4.ToString() + "-" + powersupply5.ToString() + "-" + powersupply6.ToString() + "-" + powersupply7.ToString() + "-" + powersupply8.ToString() + "-" + powersupply9.ToString() + "-" + powersupply10.ToString() + "-" + powersupply11.ToString() + "-" + powersupply12.ToString() + "-" + powersupply13.ToString() + "-" + powersupply14.ToString() + "-" + powersupply15.ToString() + "-" + powersupply16.ToString() + "-" + powersupply17.ToString() + "-" + powersupply18.ToString() + "-" + powersupply19.ToString() + "-" + powersupply20.ToString();
            graphiccard = graphiccard1.ToString() + "-" + graphiccard2.ToString() + "-" + graphiccard3.ToString() + "-" + graphiccard4.ToString() + "-" + graphiccard5.ToString() + "-" + graphiccard6.ToString() + "-" + graphiccard7.ToString() + "-" + graphiccard8.ToString() + "-" + graphiccard9.ToString() + "-" + graphiccard10.ToString() + "-" + graphiccard11.ToString() + "-" + graphiccard12.ToString() + "-" + graphiccard13.ToString() + "-" + graphiccard14.ToString() + "-" + graphiccard15.ToString() + "-" + graphiccard16.ToString() + "-" + graphiccard17.ToString() + "-" + graphiccard18.ToString() + "-" + graphiccard19.ToString() + "-" + graphiccard20.ToString();

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

            Debug.Log("��������� ������: " + www.error);
            yield break;


        }

        else
        {
            answer = www.text;
        }
    }
     private IEnumerator Checks()
    {
        
        WWWForm form = new WWWForm();
        
        WWW www = new WWW("http://doublenikmak.ru/Leaderboard/date.php", form);

        yield return www;
        
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            yield break;
        }       
    }
}
