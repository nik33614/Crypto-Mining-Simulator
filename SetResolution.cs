using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    
    void Start()
    {
        PlayerPrefs.SetInt("resolution", 0);
    }

    
}
