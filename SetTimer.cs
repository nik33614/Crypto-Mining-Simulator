using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimer : MonoBehaviour
{

    float a;

    void Start()
    {
        a = PlayerPrefs.GetFloat("timer");

        if(a == 0)
        {
            PlayerPrefs.SetFloat("timer", 6);
        }

    }

    
}
