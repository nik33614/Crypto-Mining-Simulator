using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBuyRunch2 : MonoBehaviour
{
    int jetupgrade;
    int cost;
    public UnityEngine.UI.Text ScoresText;
    public GameObject start;
    public GameObject starts;
    void Update()
    {

        jetupgrade = PlayerPrefs.GetInt("runupgrade2");
        //Debug.Log(jetupgrade);

        if (jetupgrade == 0)
        {
            cost = 6;

            

            string a = cost.ToString();

            a = a + " $";

            ScoresText.text = a;

            PlayerPrefs.SetInt("costrunupgrade2", cost);
        }

        else
        {
            int z = PlayerPrefs.GetInt("character");
            if (z == 1 && jetupgrade >= 10)
            {
                start.SetActive(false);
                starts.SetActive(true);
            }
            //if (z == 1 && jetupgrade == 10)
            //{
            //    start.SetActive(false);
            //    starts.SetActive(true);
            //}
            if (z == 2 && jetupgrade == 15)
            {
                start.SetActive(false);
                starts.SetActive(true);
            }
            else
            {
                float timer = PlayerPrefs.GetFloat("run2");

                cost = jetupgrade + 2;

                cost = cost * 13;

                string a = cost.ToString();

                a = a + " $";

                ScoresText.text = a;
                PlayerPrefs.SetInt("costrunupgrade2", cost);
            }
            
            
        }
    }
}
