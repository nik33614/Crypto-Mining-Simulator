using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOff : MonoBehaviour
{
    int checkMusic;
    public GameObject Off;
    public GameObject On;

    void Start()
    {
        //PlayerPrefs.SetInt("Music", 0);
        checkMusic = PlayerPrefs.GetInt("Music");
        Debug.Log(checkMusic);
        if (checkMusic == 1)
        {
            Off.SetActive(true);
            On.SetActive(false);
        }

    }

    public void OnClick()
    {
        checkMusic = PlayerPrefs.GetInt("Music");

        checkMusic += 1;

        PlayerPrefs.SetInt("Music", checkMusic);

        Off.SetActive(true);
        On.SetActive(false);
        

    }
}
