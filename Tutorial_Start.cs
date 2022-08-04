using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Tutorial_Start : MonoBehaviour
{
    public GameObject BackGround_1_Light;
    public GameObject BackGround_1_Dark;

    void Start()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;

        if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
        {
            BackGround_1_Dark.SetActive(true);
            BackGround_1_Light.SetActive(false);
        }
        else
        {
            BackGround_1_Light.SetActive(true);
            BackGround_1_Dark.SetActive(false);
        }
    }
}
