using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourScore : MonoBehaviour
{

    int scorelast;

    public UnityEngine.UI.Text ScoresText;

    public string a;



    void Update()
    {
        scorelast = PlayerPrefs.GetInt("scorelast");

        a = scorelast.ToString();

        a = a + " m";

        ScoresText.text = a;

    }

    
}
