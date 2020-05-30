using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneIntro : MonoBehaviour
{
    
    public float timer;
    public int a;

    void Update()
    {
       
        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {
   
        if (timer <= 0)
        {
            Application.LoadLevel(a);

        }

    }
}
