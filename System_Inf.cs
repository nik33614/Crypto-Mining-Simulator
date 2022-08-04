using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class System_Inf : MonoBehaviour
{
    public Text Cpu;
    public Text Motherboard;
    public Text GraphicCard;
    public Text Power;
    public Text Cooling;

    void Start()
    {
        switch (PlayerPrefs.GetInt("cpu"))
        {
            case 1:
                Cpu.text = "CPU: Intel Pentium";
                break;
            case 2:
                Cpu.text = "CPU: Intel Celeron";
                break ;
            case 3:
                Cpu.text = "CPU: AMD Ryzen 7";
                break;
            case 4:
                Cpu.text = "CPU: Intel Core i5";
                break;
            case 5:
                Cpu.text = "CPU: AMD Ryzen 9";
                break;
            case 6:
                Cpu.text = "CPU: Intel Core i9";
                break;
        }
        switch(PlayerPrefs.GetInt("motherboard"))
        {
            case 1:
                Motherboard.text = "MotherBoard: ASUS Prime H510-K";
                break;
            case 2:
                Motherboard.text = "MotherBoard: ASRock H470M-HVS";
                break;
            case 3:
                Motherboard.text = "MotherBoard: MSI MPG X570";
                break;
            case 4:
                Motherboard.text = "MotherBoard: MSI MEG Z59OI";
                break;
            case 5:
                Motherboard.text = "MotherBoard: MSI MEG X570 ACE";
                break;
            case 6:
                Motherboard.text = "MotherBoard: Asus PRIME Z490-A";
                break;
        }
        switch(PlayerPrefs.GetInt("graphiccard"))
        {
            case 1:
                GraphicCard.text = "GPU: GeForce GTX 560";
                break;
            case 2:
                GraphicCard.text = "GPU: Radeon R9 380";
                break;
            case 3:
                GraphicCard.text = "GPU: GeForce GTX 1050 Ti";
                break;
            case 4:
                GraphicCard.text = "GPU: GeForce GTX 1660";
                break;
            case 5:
                GraphicCard.text = "GPU: GeForce RTX 2070";
                break;
            case 6:
                GraphicCard.text = "GPU: GeForce RTX 3090";
                break;
        }
        switch(PlayerPrefs.GetInt("power"))
        {
            case 1:
                Power.text = "Power supply: HIPRO HPE-350W";
                break;
            case 2:
                Power.text = "Power supply: Be quiet BN245";
                break;
            case 3:
                Power.text = "Power supply: Deepcool Aurora DA";
                break;
            case 4:
                Power.text = "Power supply: Seasonic FOCUS PX";
                break;
            case 5:
                Power.text = "Power supply: Corsair RM850x";
                break;
            case 6:
                Power.text = "Power supply: Super Flower Leadex";
                break;
        }
        switch (PlayerPrefs.GetInt("cooling"))
        {
            case 1:
                Power.text = "Cooling system: Deepcool GAMMAXX";
                break;
            case 2:
                Power.text = "Cooling system: Enermax Liqmax III";
                break;
            case 3:
                Power.text = "Cooling system: NZXT Kraken X63";
                break;
            case 4:
                Power.text = "Cooling system: Fractal Design Celsius+";
                break;
            case 5:
                Power.text = "Cooling system: ARCTIC Liquid Freezer II";
                break;
            case 6:
                Power.text = "Cooling system: Alphacool Eisbaer";
                break;
        }
    }
}
