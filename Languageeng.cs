using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Languageeng : MonoBehaviour
{
    public void Change()
    {
        int language = PlayerPrefs.GetInt("language");
        if (language == 0)
        {
            language += 1;
            PlayerPrefs.SetInt("language", language);
            Application.LoadLevel(13);


        }


    }
   
}
