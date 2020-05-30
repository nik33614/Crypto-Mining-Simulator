using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public int a;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (a == 5)
            {
                PlayerPrefs.SetFloat("Speed", 1.5f);
                Application.LoadLevel(12);
            }
            else
            {

                Application.LoadLevel(6);

                PlayerPrefs.SetFloat("Speed", 1.5f);
            }
        }

    }


}
