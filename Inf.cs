using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inf : MonoBehaviour
{
    void Start()
    {
        int code = PlayerPrefs.GetInt("code");
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
        int powersupply4 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
        int powersupply5 = PlayerPrefs.GetInt("Mother_Board_upgrade_PC1");
    }
}
