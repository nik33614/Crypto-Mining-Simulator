using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource MusicSource;

	public AudioClip MusicClip;

    int checkFX;

	void Start()
	{
        checkFX = PlayerPrefs.GetInt("music");

        if (checkFX == 0)
        {

            MusicSource.PlayOneShot(MusicClip);
        }
	}
}
