using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOn : MonoBehaviour
{
    int checkMusic;
    public GameObject Off;
    public GameObject On;

    void Start()
    {
        //PlayerPrefs.SetInt("FX", 0);

        checkMusic = PlayerPrefs.GetInt("Music");
        if (checkMusic == 0)
        {

            On.SetActive(true);
            Off.SetActive(false);
        }

    }

    public void OnClick()
    {
        checkMusic = PlayerPrefs.GetInt("Music");

        checkMusic -= 1;

        PlayerPrefs.SetInt("Music", checkMusic);


        On.SetActive(true);
        Off.SetActive(false);

    }
}
