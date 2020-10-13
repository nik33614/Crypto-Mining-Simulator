using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float timer = 0;
    public UnityEngine.UI.Text ScoresText;
    public string a;

     void Start()
    {
        timer = PlayerPrefs.GetInt("scorenow");
    }

    void Update()
    {
        

        float plus = PlayerPrefs.GetFloat("Speed");

        timer = timer + plus * Time.deltaTime;

       

        int m = Mathf.RoundToInt(timer);
        if(m == 10)
        {
            int z = PlayerPrefs.GetInt("10");
            if (z == 0)
            {
                z += 1;
                PlayerPrefs.SetInt("10", z);
            }
        }

        if (m == 250)
        {

            int z = PlayerPrefs.GetInt("100");
            if (z == 0)
            {
                z += 1;
                PlayerPrefs.SetInt("100", z);
            }
        }

        if (m == 500)
        {
            int z = PlayerPrefs.GetInt("250");
            if (z == 0)
            {
                z += 1;
                PlayerPrefs.SetInt("250", z);
            }
        }




        PlayerPrefs.SetInt("scorenow", m);

        a = m.ToString();

        a = a + " m";

        ScoresText.text = a;

    }
            
       
}
