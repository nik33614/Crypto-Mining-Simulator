using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutuorialcheck : MonoBehaviour
{
    int a;
    public GameObject start;
    public float timer;

    void Start()
    {
        a = PlayerPrefs.GetInt("tutorial");
        if (a == 0)
        {
        PlayerPrefs.SetFloat("Speed", 1.5f);
        start.SetActive(true);
           

        }

    }

   


    void Update()
    {

        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {

        if (timer <= 0)
        {
            start.SetActive(false);

            PlayerPrefs.SetFloat("Speed", 1.5f);
            PlayerPrefs.SetInt("tutorial", 2);

        }

    }
   


}
