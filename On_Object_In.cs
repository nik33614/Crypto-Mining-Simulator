using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On_Object_In : MonoBehaviour
{
   public GameObject Object;
    public float timer;

    void Start()
    {
        Object.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Plus();
        }
    }
    void Plus()
    {
        Object.SetActive(true);
    }
}
