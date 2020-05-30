using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        int change = PlayerPrefs.GetInt("Easy"); 

        if (col.tag == "Player")
        {
            if (change == 0)
            {
                int a = Random.Range(2, 4);

                Application.LoadLevel(a);
            }
            else
            {
                int a = Random.Range(9, 11);

                Application.LoadLevel(a);
            }
        }


    }
}
