using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    	public AudioSource x;

	public AudioClip y;
    int checkFX;

	public void Click()
	{
        checkFX = PlayerPrefs.GetInt("FX");

        if (checkFX == 0)
        {

            x.PlayOneShot(y);
        }
	}
}