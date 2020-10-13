using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Promocode : MonoBehaviour
{

    public Text Prom_field;
    public UnityEngine.UI.Text ScoresText;

    public void Check()
    {
        
        


        string prom = Prom_field.text.ToString();

        if(prom == "c7M3j0CRb29kl")
        {
            int a = PlayerPrefs.GetInt("money");
            a = a + 100;
            PlayerPrefs.SetInt("money", a);

            ScoresText.text = "OK!";
        }

        if (prom == "5aL1iAzB807ou")
        {
            int b = PlayerPrefs.GetInt("money");
            b = b + 500;
            PlayerPrefs.SetInt("money", b);

            ScoresText.text = "OK!";
        }

        if (prom == "o71ERCa2c93v6")
        {
            int c = PlayerPrefs.GetInt("money");
            c = c + 1000;
            PlayerPrefs.SetInt("money", c);

            ScoresText.text = "OK!";
        }

        if (prom == "j81Ea9Bhk2N6b")
        {
            PlayerPrefs.SetInt("ads", 1);

            ScoresText.text = "OK!";
        }

       
    }
}
