using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_FX : MonoBehaviour
{
    public void Music()
    {
        if(PlayerPrefs.GetInt("Music")==1)
        {
            PlayerPrefs.SetInt("Music", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Music", 1);
        }
    }
    public void FX()
    {
        if (PlayerPrefs.GetInt("Fx") == 1)
        {
            PlayerPrefs.SetInt("Fx", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Fx", 1);
        }
    }
}
