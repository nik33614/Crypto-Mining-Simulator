using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeroScore : MonoBehaviour
{
    int scorenow;
    int scorelast;
    int scorebest;

    void Start()
    {

        scorenow =  PlayerPrefs.GetInt("scorenow");

        scorelast = PlayerPrefs.GetInt("scorelast");

        scorebest = PlayerPrefs.GetInt("scorebest");

        PlayerPrefs.SetInt("scorelast", scorenow);

        

        if (scorenow > scorebest)
        {
            PlayerPrefs.SetInt("scorebest", scorenow);
        }

        PlayerPrefs.SetInt("scorenow",0);

        

    }
}
