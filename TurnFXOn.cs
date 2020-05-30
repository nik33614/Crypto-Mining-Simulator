using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFXOn : MonoBehaviour
{
    int checkFX;
    public GameObject Off;
    public GameObject On;

    void Start()
    {
        //PlayerPrefs.SetInt("FX", 0);
        checkFX = PlayerPrefs.GetInt("FX");
        Debug.Log(checkFX);
        if(checkFX == 1)
        {
            Off.SetActive(true);
            On.SetActive(false);
        }

    }

    public void OnClick()
    {
        checkFX = PlayerPrefs.GetInt("FX");

        checkFX += 1;

        PlayerPrefs.SetInt("FX", checkFX);

        

        Off.SetActive(true);
        On.SetActive(false);
    }
}
