using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    int scorebest;

    public UnityEngine.UI.Text ScoresText;

    string a;

    void Update()
    {
        scorebest = PlayerPrefs.GetInt("scorebest");

        a = scorebest.ToString();

        a = a + " m";

        ScoresText.text = a;
    }
}
