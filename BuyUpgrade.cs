using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class BuyUpgrade : MonoBehaviour
{
    int money;
    int Cost;
    int PC;
    public string Part;
    int Part_Upgrade;
    int Graphic_Card;
    int CPU;
    int Power_Supply;
    int MotherBoard;
    public UnityEngine.UI.Text CostText;
    public GameObject Max_Button;
    public GameObject Main_Button;
    public int scene;
    public GameObject Panel;

    void Start()
    {
        int PC1 = PlayerPrefs.GetInt("pc1");
        int PC2 = PlayerPrefs.GetInt("pc2");
        int PC3 = PlayerPrefs.GetInt("pc3");
        int PC4 = PlayerPrefs.GetInt("pc4");
        int PC5 = PlayerPrefs.GetInt("pc5");
        int PC6 = PlayerPrefs.GetInt("pc6");
        int PC7 = PlayerPrefs.GetInt("pc7");
        int PC8 = PlayerPrefs.GetInt("pc8");
        int PC9 = PlayerPrefs.GetInt("pc9");
        int PC10 = PlayerPrefs.GetInt("pc10");
        int PC11 = PlayerPrefs.GetInt("pc11");
        int PC12 = PlayerPrefs.GetInt("pc12");
        int PC13 = PlayerPrefs.GetInt("pc13");
        int PC14 = PlayerPrefs.GetInt("pc14");
        int PC15 = PlayerPrefs.GetInt("pc15");
        int PC16 = PlayerPrefs.GetInt("pc16");
        int PC17 = PlayerPrefs.GetInt("pc17");
        int PC18 = PlayerPrefs.GetInt("pc18");
        int PC19 = PlayerPrefs.GetInt("pc19");
        int PC20 = PlayerPrefs.GetInt("pc20");

        if (PC1 == 1)
        {
            PC = 1;
        }
        if (PC2 == 1)
        {
            PC = 2;
        }
        if (PC3 == 1)
        {
            PC = 3;
        }
        if (PC4 == 1)
        {
            PC = 4;
        }
        if (PC5 == 1)
        {
            PC = 5;
        }
        if (PC6 == 1)
        {
            PC = 6;
        }
        if (PC7 == 1)
        {
            PC = 7;
        }
        if (PC8 == 1)
        {
            PC = 8;
        }
        if (PC9 == 1)
        {
            PC = 9;
        }
        if (PC10 == 1)
        {
            PC = 10;
        }
        if (PC11 == 1)
        {
            PC = 11;
        }
        if (PC12 == 1)
        {
            PC = 12;
        }
        if (PC13 == 1)
        {
            PC = 13;
        }
        if (PC14 == 1)
        {
            PC = 14;
        }
        if (PC15 == 1)
        {
            PC = 15;
        }
        if (PC16 == 1)
        {
            PC = 16;
        }
        if (PC17 == 1)
        {
            PC = 17;
        }
        if (PC18 == 1)
        {
            PC = 18;
        }
        if (PC19 == 1)
        {
            PC = 19;
        }
        if (PC20 == 1)
        {
            PC = 20;
        }
    }

    void Update()
    {
        if (Part == "CPU" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC1");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC1_Cost", 24);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC1_Cost", 48);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC1_Cost", 96);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC1_Cost", 192);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC1_Cost", 384);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }
            Debug.Log(Part_Upgrade);
            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC1_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC2");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC2_Cost", 364);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC2_Cost", 728);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC2_Cost", 1456);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC2_Cost", 2912);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC2_Cost", 5824);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC2_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC3");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC3_Cost", 2053);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC3_Cost", 4106);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC3_Cost", 8212);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC3_Cost", 16424);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC3_Cost", 32848);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC3_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC4");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC4_Cost", 25318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC4_Cost", 50636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC4_Cost", 101272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC4_Cost", 202544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC4_Cost", 405088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC4_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC5");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC5_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC5_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC5_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC5_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC5_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC5_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC6");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC6_Cost", 72);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC6_Cost", 144);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC6_Cost", 288);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC6_Cost", 576);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC6_Cost", 1152);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC6_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC7");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 1092);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 2184);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC7_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC8");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC8_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC9");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC9_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC10");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC10_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC11");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC11_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC12");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC12_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC13");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC13_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC14");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC14_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC15");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC15_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC16");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC16_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC17");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC17_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC18");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC18_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC19");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC19_Cost").ToString() + " $";

        }
        if (Part == "CPU" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC20");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("CPU_Upgrade_PC20_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC1_Cost", 24);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC1_Cost", 48);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC1_Cost", 96);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC1_Cost", 192);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC1_Cost", 384);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC1_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC2_Cost", 364);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC2_Cost", 728);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC2_Cost", 1456);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC2_Cost", 2912);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC2_Cost", 5824);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC2_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC3_Cost", 2053);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC3_Cost", 4106);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC3_Cost", 8212);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC3_Cost", 16424);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC3_Cost", 32848);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC3_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC4_Cost", 25318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC4_Cost", 50636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC4_Cost", 101272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC4_Cost", 202544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC4_Cost", 405088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC4_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC5_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC5_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC5_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC5_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC5_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC5_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC1_Cost", 24);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC1_Cost", 48);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC1_Cost", 96);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC1_Cost", 192);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC1_Cost", 384);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC2_Cost", 364);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC2_Cost", 728);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC2_Cost", 1456);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC2_Cost", 2912);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC2_Cost", 5824);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC3_Cost", 2053);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC3_Cost", 4106);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC3_Cost", 8212);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC3_Cost", 16424);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC3_Cost", 32848);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC4_Cost", 25318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC4_Cost", 50636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC4_Cost", 101272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC4_Cost", 202544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC4_Cost", 405088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC5_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC5_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC5_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC5_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC5_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC1");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC1_Cost", 24);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC1_Cost", 48);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC1_Cost", 96);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC1_Cost", 192);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC1_Cost", 384);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC1_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC2");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC2_Cost", 364);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC2_Cost", 728);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC2_Cost", 1456);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC2_Cost", 2912);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC2_Cost", 5824);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC2_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC3");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC3_Cost", 2053);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC3_Cost", 4106);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC3_Cost", 8212);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC3_Cost", 16424);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC3_Cost", 32848);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC3_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC4");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC4_Cost", 25318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC4_Cost", 50636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC4_Cost", 101272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC4_Cost", 202544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC4_Cost", 405088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC4_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC5");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC5_Cost", 164110);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC5_Cost", 328220);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC5_Cost", 656440);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC5_Cost", 1312880);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC5_Cost", 2625760);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }


            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC5_Cost").ToString() + " $";

        }
    }
    public void Buy()
    {
        if (Part == "CPU" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC1");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC1");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC1_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC1", PlayerPrefs.GetInt("CPU_upgrade_PC1") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00004f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "CPU" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC2");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC2");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC2_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC2", PlayerPrefs.GetInt("CPU_upgrade_PC2") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00014f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "CPU" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC3");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC3");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC3_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC3", PlayerPrefs.GetInt("CPU_upgrade_PC3") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.0005f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "CPU" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC4");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC4");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC4_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC4", PlayerPrefs.GetInt("CPU_upgrade_PC4") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00512f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "CPU" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC5");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC5");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC5_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC5", PlayerPrefs.GetInt("CPU_upgrade_PC5") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.03374f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "MotherBoard" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC1_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC1", PlayerPrefs.GetInt("Mother_Board_upgrade_PC1") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00004f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "MotherBoard" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC2_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC2", PlayerPrefs.GetInt("Mother_Board_upgrade_PC2") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00014f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "MotherBoard" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC3_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC3", PlayerPrefs.GetInt("Mother_Board_upgrade_PC3") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.0005f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "MotherBoard" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC4_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC4", PlayerPrefs.GetInt("Mother_Board_upgrade_PC4") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00512f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "MotherBoard" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC5_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC5", PlayerPrefs.GetInt("Mother_Board_upgrade_PC5") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.03374f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "Power_Supply" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC1", PlayerPrefs.GetInt("Power_Supply_upgrade_PC1") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00004f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "Power_Supply" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC2", PlayerPrefs.GetInt("Power_Supply_upgrade_PC2") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00014f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "Power_Supply" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC3", PlayerPrefs.GetInt("Power_Supply_upgrade_PC3") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.0005f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }

        if (Part == "Power_Supply" && PC == 4)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC4", PlayerPrefs.GetInt("Power_Supply_upgrade_PC4") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00512f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "Power_Supply" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC5", PlayerPrefs.GetInt("Power_Supply_upgrade_PC5") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.03374f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        //
        if (Part == "Graphic_Card" && PC == 1)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC1");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC1");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC1_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC1", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC1") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00004f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "Graphic_Card" && PC == 2)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC2");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC2");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC2");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC2_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC2", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC2") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00014f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "Graphic_Card" && PC == 3)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC3");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC3");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC3");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC3_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC3", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC3") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.0005f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }
        }
        if (Part == "Graphic_Card" && PC == 4)
        {
            Debug.Log("Check");
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC4");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC4");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC4");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC4_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC4", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC4") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.00512f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }
        if (Part == "Graphic_Card" && PC == 5)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC5");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC5");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC5");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC5_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC5", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC5") + 1);
                    PlayerPrefs.SetFloat("profitsec", PlayerPrefs.GetFloat("profitsec") + 0.03374f);
                }
                else
                {
                    SceneManager.LoadScene(scene);
                }
            }
            else
            {
                Panel.SetActive(true);
            }

        }

    }
}
    

