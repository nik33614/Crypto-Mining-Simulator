using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDowloadApp : MonoBehaviour
{

    public float timer;
    int a;
    public int change;

    public void Click()
    {
        a = 1;
    }

    void Update()
    {
        if (a == 1)
        {
            timer -= Time.deltaTime;

            Plus();
        }
    }

    void Plus()
    {

        if (timer <= 0)
        {

            a = 0;
            int ab = PlayerPrefs.GetInt("money");

            ab = ab + 1500;

            PlayerPrefs.SetInt("money", ab);



        }

    }
}
