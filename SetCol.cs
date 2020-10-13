using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCol : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public string d;

    void Update()
    {
        int z = PlayerPrefs.GetInt(d);

        if(z==2)
        {
            a.SetActive(true);
            b.SetActive(false);
        }
    }
}
