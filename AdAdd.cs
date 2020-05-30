using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdAdd : MonoBehaviour
{
    void Start()
    {
        int a = PlayerPrefs.GetInt("ad");
        a = a + 1;
        PlayerPrefs.SetInt("ad", a);
    }
   
}
