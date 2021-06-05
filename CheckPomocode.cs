using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class CheckPomocode : MonoBehaviour
{
    string promocode;
    public InputField field;

    public void Exchange()
    {
        promocode = field.text;

        if(promocode == "wTFJQYm8Uv9V73ZUvM8U")
        {
            PlayerPrefs.SetFloat("balance", PlayerPrefs.GetFloat("balance") + 100f);
        }

        if (promocode == "9QxXvkDX1aer7FMJVFYa")
        {
            PlayerPrefs.SetFloat("balance", PlayerPrefs.GetFloat("balance") + 250f);
        }

        if (promocode == "Md9dRMJeJXjTNN7cCTE6")
        {
            PlayerPrefs.SetFloat("balance", PlayerPrefs.GetFloat("balance") + 1000f);
        }

        if (promocode == "xo8WqmyZ13t0iofKHcc3")
        {
            PlayerPrefs.SetInt("Ads", 1);
        }

    }
}
