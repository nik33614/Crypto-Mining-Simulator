using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    int money;
    public UnityEngine.UI.Text ScoresText;
    

    void Update()
    {
        money = PlayerPrefs.GetInt("money");

        string a = money.ToString();

        a = a + " $";

        ScoresText.text = a;

        if (money >= 150)
        {

            int za = PlayerPrefs.GetInt("0150");
            if (za == 0)
            {
                za += 1;
                PlayerPrefs.SetInt("0150", za);
            }
        }

        if (money >= 200)
        {

            int z = PlayerPrefs.GetInt("0200");
            if (z == 0)
            {
                z += 1;
                PlayerPrefs.SetInt("0200", z);
            }
        }

        if (money >= 800)
        {

            int zb = PlayerPrefs.GetInt("0800");
            if (zb == 0)
            {
                zb += 1;
                PlayerPrefs.SetInt("0800", zb);
            }
        }
    }
}
