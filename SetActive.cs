using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    
    public GameObject start;


    public float timer;
    public int a;

    void Start()
    {
        start.SetActive(true);
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

        }

    }

   

    
}
