using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneStart : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.SetInt("Easy", 1);
    }

    public void Change()
    {
        int change = PlayerPrefs.GetInt("Easy");
        
            if (change == 1)
            {
            int a = 2;

                Application.LoadLevel(a);
            }
            else
            {
            int a = 9;

                Application.LoadLevel(a);
            }

        

    }
}
