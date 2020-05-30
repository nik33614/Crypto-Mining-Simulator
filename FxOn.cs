using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxOn : MonoBehaviour
{
    int checkFX;
    public GameObject Off;
    public GameObject On;

    void Start()
    {
        //PlayerPrefs.SetInt("FX", 0);

        checkFX = PlayerPrefs.GetInt("FX");
        if (checkFX == 0)
        {
            
            On.SetActive(true);
            Off.SetActive(false);
        }

    }

    public void OnClick()
    {
        checkFX = PlayerPrefs.GetInt("FX");

        checkFX -= 1;

        PlayerPrefs.SetInt("FX", checkFX);


        On.SetActive(true);
        Off.SetActive(false);
        
    }
}
