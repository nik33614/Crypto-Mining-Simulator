using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadeEasy : MonoBehaviour
{
    

    int check;
    int a;

    public void Checker()
    {
        check = PlayerPrefs.GetInt("Easy");

        if (check == 0)
        {
            a += 1;
            PlayerPrefs.SetInt("Easy", a);
        }
        if (check == 1)
        {
            a -= 1;
            PlayerPrefs.SetInt("Easy", a);
        }
    }
}
