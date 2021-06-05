using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneIntro : MonoBehaviour
{
    
    public float timer;
    public int a;
    public int change;

    void Update()
    {
       
        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {
   
        if (timer <= 0)
        { 
           //int level = PlayerPrefs.GetInt("language");

            //if (level == 1)
            //{
            //    change = 11;
            //}
            //else
            //{
              //  change = 5;
            //}

            Application.LoadLevel(change);          

        }

    }
}
