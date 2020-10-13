using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public int change;
    public int level;
    public int a;

    void OnTriggerEnter2D(Collider2D col)
    {
            
        
            if (col.tag == "Grown")
            {
                level = PlayerPrefs.GetInt("language");
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
