using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimer : MonoBehaviour
{

    float a;

    void Start()
    {
        a = PlayerPrefs.GetFloat("timer");
        float b = PlayerPrefs.GetFloat("timer1");

        if (a == 0)
        {
            PlayerPrefs.SetFloat("timer", 6);
        }

        if (b == 0)
        {
            PlayerPrefs.SetFloat("timer1", 6);
        }

    }

    
}
