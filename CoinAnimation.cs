using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{

    public GameObject first;
    public GameObject second;
    public AudioSource x;

    public AudioClip y;

    int checkFX;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            checkFX = PlayerPrefs.GetInt("FX");

            if (checkFX == 0)
            {

                x.PlayOneShot(y);

                x.PlayOneShot(y);
            }
                first.SetActive(false);
                second.SetActive(true);
            
        }
    }
}
