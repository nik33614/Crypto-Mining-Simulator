using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : MonoBehaviour
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

        if (check == 2)
        {
            z = -30;
        }
        else
        {
            z = 0;
        }



        if (a == 1)
        {

            if (check == 2)
            {
                transform.Rotate(new Vector3(0, 0, z) * Time.deltaTime);
            }
        }
    }
}
