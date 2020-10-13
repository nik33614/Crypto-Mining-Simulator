using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public int a;
    int change;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            if (a == 5)
            {
                int level = PlayerPrefs.GetInt("language");
                if (level == 1)
                {
                    change = 18;
                }
                else
                {
                    change = 12;
                }

                PlayerPrefs.SetFloat("Speed", 1.5f);
                Application.LoadLevel(change);
            }
            else
            {
                int level = PlayerPrefs.GetInt("language");
                if (level == 1)
                {
                    change = 16;
                }
                else
                {
                    change = 6;
                }
                PlayerPrefs.SetFloat("Speed", 1.5f);
                Application.LoadLevel(change);

                
            }
        }

    }


}
