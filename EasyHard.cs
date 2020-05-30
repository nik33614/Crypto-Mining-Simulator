using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class EasyHard : MonoBehaviour
{
    
    int checkup;
    public UnityEngine.UI.Text ScoresText;

    void Update()
    {
        checkup = PlayerPrefs.GetInt("Easy");
        if (checkup == 0)
        {
            ScoresText.text = "Easy";
        }
        if (checkup == 1)
        {
            ScoresText.text = "Hard";
        }
    }

   
}
