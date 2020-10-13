using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co2Collect : MonoBehaviour
{
    public float timer;
    
    public GameObject first;


    void Update()
    {

        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {

        if (timer <= 0)
        {



            first.SetActive(false);
            first.SetActive(true);
            PlayerPrefs.SetFloat("co2", 1);

            Destroy(gameObject);

        }

    }
}
