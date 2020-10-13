using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co2GameOver : MonoBehaviour
{
    float fill;
    int change;

    // Update is called once per frame
    void Update()
    {
        fill = PlayerPrefs.GetFloat("co2");
        int level = PlayerPrefs.GetInt("language");
        if (fill <= 0)
        {
            if (level == 1)
            {
                change = 16;
            }
            else
            {
                change = 6;
            }
            PlayerPrefs.SetFloat("Speed", 1.5f);
            Application.LoadLevel(change);
        }
    }
}

