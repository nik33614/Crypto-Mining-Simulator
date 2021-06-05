using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Starts : MonoBehaviour
{
    
    void Start()
    {
        // PlayerPrefs.SetFloat("balance", 0);
        int tutorial = PlayerPrefs.GetInt("tutorial");
        if (tutorial == 0)
        {
            PlayerPrefs.SetFloat("profit", 0.001f);
            PlayerPrefs.SetInt("tutorial", 1);
        }
    }
}
