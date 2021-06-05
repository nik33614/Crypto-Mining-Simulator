using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx: MonoBehaviour
{
    public AudioSource FXSource;

    public AudioClip FXClip;

    //int checkFX;

	public void Click()
	{
        //checkFX = PlayerPrefs.GetInt("fx");
        //Debug.Log(PlayerPrefs.GetInt("fx"));
        //if (PlayerPrefs.GetInt("fx") == 0)
        //{

        FXSource.PlayOneShot(FXClip);
        //}

        //else
        //{
        //    int a = 1 + 1;
        //}
	}
}