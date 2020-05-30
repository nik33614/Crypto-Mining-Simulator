using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TurnLeft : MonoBehaviour
{
    

    int a = 1;

    int check;

    int z;

    void OnTriggerExit2D(Collider2D collision)
    {
        
            a = 1;

        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Grown")
        {
            a = 0;

            check = 0;
           
        }
    }

    void Update()
    {

        check = PlayerPrefs.GetInt("cheks");

        if(check==1)
        {
            z = 30;
        }
        else
        {
            z = 0;
        }

       //s Debug.Log();

        if (a == 1)
        {
            if (check == 1)
            {
                transform.Rotate(new Vector3(0, 0, z) * Time.deltaTime);
            }
        }
    }
}
