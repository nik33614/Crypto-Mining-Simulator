using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetChangescene : MonoBehaviour
{

    public float timer;
   


    void Update()
    {

        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {
        int change = PlayerPrefs.GetInt("Easy");
        if (timer <= 0)
        {
            
                int a = Random.Range(2, 4);

                Application.LoadLevel(a);
            

        }

    }



}
