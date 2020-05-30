using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFx : MonoBehaviour
{
    	public AudioSource x;

	public AudioClip y;

    int checkFX;

	void Start()
	{
        checkFX = PlayerPrefs.GetInt("Music");

        if (checkFX == 0)
        {

            x.PlayOneShot(y);
        }
	}
}
