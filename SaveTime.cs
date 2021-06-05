
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class SaveTime : MonoBehaviour
{
    long currenttime;
    void Update()
    {
        long currenttime = System.DateTime.UtcNow.Ticks;
        PlayerPrefs.SetString("time", currenttime.ToString());
        //currenttime = System.DateTime.UtcNow.Ticks;
        long savedTime = long.Parse(PlayerPrefs.GetString("time", currenttime.ToString()));
        System.TimeSpan timeSpan = System.DateTime.UtcNow - new System.DateTime(savedTime);
        Debug.Log(timeSpan);
    }
}
