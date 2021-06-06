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
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 4368);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 8736);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC7_Cost", 17472);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 6159);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 12318);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 24636);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 49272);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC8_Cost", 98544);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 75954);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 151908);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC9_Cost", 1215264);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 492330);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 984660);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 1969320);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 3938640);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC10_Cost", 7877280);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 144);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 288);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 576);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 1152);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC11_Cost", 2304);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 2184);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 4296);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 8592);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 17184);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC12_Cost", 34368);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 12318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 24636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 49272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 98544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC13_Cost", 197088);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 151908);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC14_Cost", 1822896);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 984660);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 1969320);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 3938640);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 7877280);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC15_Cost", 15754560);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 240);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 480);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 960);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 1920);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC16_Cost", 3840);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 3640);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 7280);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 14560);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 29120);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC17_Cost", 58240);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 20530);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 41060);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 82120);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 164240);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC18_Cost", 328480);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 253180);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 506360);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 1012720);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 2025440);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC19_Cost", 4050880);
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
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 1641100);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 3282200);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 6564400);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 13128800);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("CPU_Upgrade_PC20_Cost", 26257600);
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
        if (Part == "MotherBoard" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC6");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC6_Cost", 72);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC6_Cost", 144);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC6_Cost", 288);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC6_Cost", 576);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC6_Cost", 1152);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC6_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC7");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC7_Cost", 1092);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC7_Cost", 2184);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC7_Cost", 4368);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC7_Cost", 8736);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC7_Cost", 17472);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC7_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC8");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC8_Cost", 6159);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC8_Cost", 12318);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC8_Cost", 24636);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC8_Cost", 49272);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC8_Cost", 98544);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC8_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC9");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC9_Cost", 75954);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC9_Cost", 151908);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC9_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC9_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC9_Cost", 1215264);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC9_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC10");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC10_Cost", 492330);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC10_Cost", 984660);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC10_Cost", 1969320);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC10_Cost", 3938640);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC10_Cost", 7877280);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC10_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC11");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC11_Cost", 144);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC11_Cost", 288);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC11_Cost", 576);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC11_Cost", 1152);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC11_Cost", 2304);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC11_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC12");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC12_Cost", 2184);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC12_Cost", 4296);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC12_Cost", 8592);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC12_Cost", 17184);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC12_Cost", 34368);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC12_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC13");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC13_Cost", 12318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC13_Cost", 24636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC13_Cost", 49272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC13_Cost", 98544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC13_Cost", 197088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC13_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC14");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC14_Cost", 151908);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC14_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC14_Cost", 1822896);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC14_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC15");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC15_Cost", 984660);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC15_Cost", 1969320);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC15_Cost", 3938640);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC15_Cost", 7877280);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC15_Cost", 15754560);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC15_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC16");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC16_Cost", 240);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC16_Cost", 480);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC16_Cost", 960);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC16_Cost", 1920);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC16_Cost", 3840);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC16_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC17");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC17_Cost", 3640);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC17_Cost", 7280);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC17_Cost", 14560);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC17_Cost", 29120);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC17_Cost", 58240);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC17_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC18");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC18_Cost", 20530);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC18_Cost", 41060);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC18_Cost", 82120);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC18_Cost", 164240);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC18_Cost", 328480);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC18_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC19");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC19_Cost", 253180);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC19_Cost", 506360);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC19_Cost", 1012720);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC19_Cost", 2025440);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC19_Cost", 4050880);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC19_Cost").ToString() + " $";

        }
        if (Part == "MotherBoard" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC20");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC20_Cost", 1641100);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC20_Cost", 3282200);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC20_Cost", 6564400);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC20_Cost", 13128800);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Mother_Board_Upgrade_PC20_Cost", 26257600);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC20_Cost").ToString() + " $";

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
        if (Part == "Power_Supply" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC6_Cost", 72);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC6_Cost", 144);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC6_Cost", 288);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC6_Cost", 576);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC6_Cost", 1152);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC7_Cost", 1092);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC7_Cost", 2184);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC7_Cost", 4368);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC7_Cost", 8736);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC7_Cost", 17472);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC8_Cost", 6159);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC8_Cost", 12318);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC8_Cost", 24636);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC8_Cost", 49272);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC8_Cost", 98544);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC9_Cost", 75954);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC9_Cost", 151908);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC9_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC9_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC9_Cost", 1215264);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC10_Cost", 492330);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC10_Cost", 984660);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC10_Cost", 1969320);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC10_Cost", 3938640);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC10_Cost", 7877280);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC11_Cost", 144);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC11_Cost", 288);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC11_Cost", 576);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC11_Cost", 1152);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC11_Cost", 2304);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC12_Cost", 2184);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC12_Cost", 4296);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC12_Cost", 8592);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC12_Cost", 17184);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC12_Cost", 34368);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC13_Cost", 12318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC13_Cost", 24636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC13_Cost", 49272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC13_Cost", 98544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC13_Cost", 197088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC14_Cost", 151908);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC14_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC14_Cost", 1822896);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC15_Cost", 984660);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC15_Cost", 1969320);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC15_Cost", 3938640);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC15_Cost", 7877280);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC15_Cost", 15754560);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC16_Cost", 240);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC16_Cost", 480);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC16_Cost", 960);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC16_Cost", 1920);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC16_Cost", 3840);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC17_Cost", 3640);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC17_Cost", 7280);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC17_Cost", 14560);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC17_Cost", 29120);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC17_Cost", 58240);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC18_Cost", 20530);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC18_Cost", 41060);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC18_Cost", 82120);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC18_Cost", 164240);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC18_Cost", 328480);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC19_Cost", 253180);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC19_Cost", 506360);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC19_Cost", 1012720);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC19_Cost", 2025440);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC19_Cost", 4050880);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19_Cost").ToString() + " $";

        }
        if (Part == "Power_Supply" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC20_Cost", 1641100);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC20_Cost", 3282200);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC20_Cost", 6564400);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC20_Cost", 13128800);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Power_Supply_upgrade_PC20_Cost", 26257600);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20_Cost").ToString() + " $";

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
        if (Part == "Graphic_Card" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC6");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC6_Cost", 72);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC6_Cost", 144);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC6_Cost", 288);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC6_Cost", 576);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC6_Cost", 1152);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC6_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC7");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC7_Cost", 1092);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC7_Cost", 2184);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC7_Cost", 4368);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC7_Cost", 8736);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC7_Cost", 17472);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC7_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC8");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC8_Cost", 6159);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC8_Cost", 12318);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC8_Cost", 24636);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC8_Cost", 49272);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC8_Cost", 98544);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC8_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC9");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC9_Cost", 75954);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC9_Cost", 151908);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC9_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC9_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC9_Cost", 1215264);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC9_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC10");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC10_Cost", 492330);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC10_Cost", 984660);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC10_Cost", 1969320);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC10_Cost", 3938640);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC10_Cost", 7877280);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC10_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC11");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC11_Cost", 144);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC11_Cost", 288);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC11_Cost", 576);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC11_Cost", 1152);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC11_Cost", 2304);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC11_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC12");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC12_Cost", 2184);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC12_Cost", 4296);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC12_Cost", 8592);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC12_Cost", 17184);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC12_Cost", 34368);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC12_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC13");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC13_Cost", 12318);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC13_Cost", 24636);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC13_Cost", 49272);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC13_Cost", 98544);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC13_Cost", 197088);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC13_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC14");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC14_Cost", 151908);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC14_Cost", 303816);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC14_Cost", 607632);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC14_Cost", 1822896);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC14_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC15");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC15_Cost", 984660);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC15_Cost", 1969320);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC15_Cost", 3938640);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC15_Cost", 7877280);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC15_Cost", 15754560);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC15_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC16");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC16_Cost", 240);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC16_Cost", 480);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC16_Cost", 960);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC16_Cost", 1920);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC16_Cost", 3840);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC16_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC17");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC17_Cost", 3640);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC17_Cost", 7280);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC17_Cost", 14560);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC17_Cost", 29120);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC17_Cost", 58240);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC17_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC18");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC18_Cost", 20530);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC18_Cost", 41060);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC18_Cost", 82120);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC18_Cost", 164240);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC18_Cost", 328480);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC18_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC19");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC19_Cost", 253180);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC19_Cost", 506360);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC19_Cost", 1012720);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC19_Cost", 2025440);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC19_Cost", 4050880);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC19_Cost").ToString() + " $";

        }
        if (Part == "Graphic_Card" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC20");
            if (Part_Upgrade == 0)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC20_Cost", 1641100);
            }
            if (Part_Upgrade == 1)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC20_Cost", 3282200);
            }
            if (Part_Upgrade == 2)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC20_Cost", 6564400);
            }
            if (Part_Upgrade == 3)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC20_Cost", 13128800);
            }
            if (Part_Upgrade == 4)
            {
                PlayerPrefs.SetInt("Graphic_Card_Upgrade_PC20_Cost", 26257600);
            }
            if (Part_Upgrade == 5)
            {
                Max_Button.SetActive(true);
                Main_Button.SetActive(false);
            }

            CostText.text = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC20_Cost").ToString() + " $";

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
        if (Part == "CPU" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC6");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC6");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC6");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC6_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC6", PlayerPrefs.GetInt("CPU_upgrade_PC6") + 1);
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
        if (Part == "CPU" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC7");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC7");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC7");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC7_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC7", PlayerPrefs.GetInt("CPU_upgrade_PC7") + 1);
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
        if (Part == "CPU" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC8");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC8");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC8");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC8_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC8", PlayerPrefs.GetInt("CPU_upgrade_PC8") + 1);
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
        if (Part == "CPU" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC9");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC9");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC9");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC9_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC9", PlayerPrefs.GetInt("CPU_upgrade_PC9") + 1);
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
        if (Part == "CPU" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC10");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC10");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC10");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC10_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC10", PlayerPrefs.GetInt("CPU_upgrade_PC10") + 1);
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
        if (Part == "CPU" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC11");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC11");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC11");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC11_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC11", PlayerPrefs.GetInt("CPU_upgrade_PC11") + 1);
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
        if (Part == "CPU" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC12");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC12");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC12");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC12_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC12", PlayerPrefs.GetInt("CPU_upgrade_PC12") + 1);
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
        if (Part == "CPU" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC13");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC13");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC13");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC13_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC13", PlayerPrefs.GetInt("CPU_upgrade_PC13") + 1);
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
        if (Part == "CPU" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC14");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC14");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC14");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC14_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC14", PlayerPrefs.GetInt("CPU_upgrade_PC14") + 1);
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
        if (Part == "CPU" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC15");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC15");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC15");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC15_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC15", PlayerPrefs.GetInt("CPU_upgrade_PC15") + 1);
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
        if (Part == "CPU" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC16");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC16");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC16");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC16_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC16", PlayerPrefs.GetInt("CPU_upgrade_PC16") + 1);
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
        if (Part == "CPU" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC17");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC17");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC17");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC17_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC17", PlayerPrefs.GetInt("CPU_upgrade_PC17") + 1);
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
        if (Part == "CPU" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC18");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC18");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC18");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC18_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC18", PlayerPrefs.GetInt("CPU_upgrade_PC18") + 1);
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
        if (Part == "CPU" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC19");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC19");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC19");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC19_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC19", PlayerPrefs.GetInt("CPU_upgrade_PC19") + 1);
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
        if (Part == "CPU" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("CPU_upgrade_PC20");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC20");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20");
            Graphic_Card = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC20");
            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade <= Graphic_Card && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("CPU_Upgrade_PC20_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("CPU_upgrade_PC20", PlayerPrefs.GetInt("CPU_upgrade_PC20") + 1);
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
        if (Part == "MotherBoard" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC6");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC6_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC6", PlayerPrefs.GetInt("Mother_Board_upgrade_PC6") + 1);
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
        if (Part == "MotherBoard" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC7");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC7_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC7", PlayerPrefs.GetInt("Mother_Board_upgrade_PC7") + 1);
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
        if (Part == "MotherBoard" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC8");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC8_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC8", PlayerPrefs.GetInt("Mother_Board_upgrade_PC8") + 1);
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
        if (Part == "MotherBoard" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC9");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC9_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC9", PlayerPrefs.GetInt("Mother_Board_upgrade_PC9") + 1);
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
        if (Part == "MotherBoard" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC10");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC10_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC10", PlayerPrefs.GetInt("Mother_Board_upgrade_PC10") + 1);
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
        if (Part == "MotherBoard" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC11");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC11_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC11", PlayerPrefs.GetInt("Mother_Board_upgrade_PC11") + 1);
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
        if (Part == "MotherBoard" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC12");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC12_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC12", PlayerPrefs.GetInt("Mother_Board_upgrade_PC12") + 1);
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
        if (Part == "MotherBoard" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC13");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC13_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC13", PlayerPrefs.GetInt("Mother_Board_upgrade_PC13") + 1);
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
        if (Part == "MotherBoard" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC14");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC14_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC14", PlayerPrefs.GetInt("Mother_Board_upgrade_PC14") + 1);
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
        if (Part == "MotherBoard" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC15");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC15_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC15", PlayerPrefs.GetInt("Mother_Board_upgrade_PC15") + 1);
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
        if (Part == "MotherBoard" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC16");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC16_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC16", PlayerPrefs.GetInt("Mother_Board_upgrade_PC16") + 1);
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
        if (Part == "MotherBoard" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC17");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC17_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC17", PlayerPrefs.GetInt("Mother_Board_upgrade_PC17") + 1);
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
        if (Part == "MotherBoard" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC18");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC18_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC18", PlayerPrefs.GetInt("Mother_Board_upgrade_PC18") + 1);
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
        if (Part == "MotherBoard" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC19");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC19_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC19", PlayerPrefs.GetInt("Mother_Board_upgrade_PC19") + 1);
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
        if (Part == "MotherBoard" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Mother_Board_upgrade_PC20");
            if (Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Mother_Board_Upgrade_PC20_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Mother_Board_upgrade_PC20", PlayerPrefs.GetInt("Mother_Board_upgrade_PC20") + 1);
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
        if (Part == "Power_Supply" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC6");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC6", PlayerPrefs.GetInt("Power_Supply_upgrade_PC6") + 1);
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
        if (Part == "Power_Supply" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC7");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC7", PlayerPrefs.GetInt("Power_Supply_upgrade_PC7") + 1);
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
        if (Part == "Power_Supply" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC8");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC8", PlayerPrefs.GetInt("Power_Supply_upgrade_PC8") + 1);
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
        if (Part == "Power_Supply" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC9");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC9", PlayerPrefs.GetInt("Power_Supply_upgrade_PC9") + 1);
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
        if (Part == "Power_Supply" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC10");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC10", PlayerPrefs.GetInt("Power_Supply_upgrade_PC10") + 1);
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
        if (Part == "Power_Supply" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC11");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC11", PlayerPrefs.GetInt("Power_Supply_upgrade_PC11") + 1);
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
        if (Part == "Power_Supply" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC12");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC12", PlayerPrefs.GetInt("Power_Supply_upgrade_PC12") + 1);
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
        if (Part == "Power_Supply" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC13");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC13", PlayerPrefs.GetInt("Power_Supply_upgrade_PC13") + 1);
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
        if (Part == "Power_Supply" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC14");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC14", PlayerPrefs.GetInt("Power_Supply_upgrade_PC14") + 1);
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
        if (Part == "Power_Supply" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC15");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC15", PlayerPrefs.GetInt("Power_Supply_upgrade_PC15") + 1);
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
        if (Part == "Power_Supply" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC16");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC16", PlayerPrefs.GetInt("Power_Supply_upgrade_PC16") + 1);
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
        if (Part == "Power_Supply" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC17");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC17", PlayerPrefs.GetInt("Power_Supply_upgrade_PC17") + 1);
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
        if (Part == "Power_Supply" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC18");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC18", PlayerPrefs.GetInt("Power_Supply_upgrade_PC18") + 1);
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
        if (Part == "Power_Supply" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC19");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC19", PlayerPrefs.GetInt("Power_Supply_upgrade_PC19") + 1);
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
        if (Part == "Power_Supply" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC20");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Power_Supply_upgrade_PC20", PlayerPrefs.GetInt("Power_Supply_upgrade_PC20") + 1);
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
        if (Part == "Graphic_Card" && PC == 6)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC6");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC6");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC6");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC6_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC6", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC6") + 1);
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
        if (Part == "Graphic_Card" && PC == 7)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC7");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC7");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC7");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC7_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC7", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC7") + 1);
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
        if (Part == "Graphic_Card" && PC == 8)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC8");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC8");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC8");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC8_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC8", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC8") + 1);
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
        if (Part == "Graphic_Card" && PC == 9)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC9");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC9");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC9");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC9_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC9", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC9") + 1);
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
        if (Part == "Graphic_Card" && PC == 10)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC10");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC10");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC10");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC10_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC10", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC10") + 1);
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
        if (Part == "Graphic_Card" && PC == 11)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC11");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC11");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC11");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC11_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC11", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC11") + 1);
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
        if (Part == "Graphic_Card" && PC == 12)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC12");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC12");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC12");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC12_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC12", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC12") + 1);
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
        if (Part == "Graphic_Card" && PC == 13)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC13");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC13");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC13");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC13_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC13", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC13") + 1);
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
        if (Part == "Graphic_Card" && PC == 14)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC14");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC14");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC14");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC14_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC14", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC14") + 1);
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
        if (Part == "Graphic_Card" && PC == 15)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC15");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC15");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC15");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC15_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC15", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC15") + 1);
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
        if (Part == "Graphic_Card" && PC == 16)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC16");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC16");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC16");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC16_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC16", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC16") + 1);
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
        if (Part == "Graphic_Card" && PC == 17)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC17");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC17");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC17");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC17_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC17", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC17") + 1);
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
        if (Part == "Graphic_Card" && PC == 18)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC18");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC18");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC18");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC18_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC18", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC18") + 1);
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
        if (Part == "Graphic_Card" && PC == 19)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC19");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC19");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC19");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC19_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC19", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC19") + 1);
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
        if (Part == "Graphic_Card" && PC == 20)
        {
            Part_Upgrade = PlayerPrefs.GetInt("Graphic_Card_upgrade_PC20");
            MotherBoard = PlayerPrefs.GetInt("Mother_Board_upgrade_PC20");
            Power_Supply = PlayerPrefs.GetInt("Power_Supply_upgrade_PC20");

            if (Part_Upgrade <= MotherBoard && Part_Upgrade <= Power_Supply && Part_Upgrade < 5)
            {
                money = PlayerPrefs.GetInt("balancedollars");
                Cost = PlayerPrefs.GetInt("Graphic_Card_Upgrade_PC20_Cost");
                if (money >= Cost)
                {
                    PlayerPrefs.SetInt("balancedollars", money -= Cost);
                    PlayerPrefs.SetInt("Graphic_Card_upgrade_PC20", PlayerPrefs.GetInt("Graphic_Card_upgrade_PC20") + 1);
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


    }
}