using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    int z;
    int za;
    int zb;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public string first;
    public string second;
    public string three;

    void Update()
    {
        z = PlayerPrefs.GetInt(first);
        if (z == 1)
        {
            
            a.SetActive(true);
        }

        za = PlayerPrefs.GetInt(second);
        if (za == 1)
        {
            za -= 1;
            
            b.SetActive(true);
        }

        zb = PlayerPrefs.GetInt(three);
        if (zb == 1)
        {
            zb -= 1;
            
            c.SetActive(true);
        }
    }
}
