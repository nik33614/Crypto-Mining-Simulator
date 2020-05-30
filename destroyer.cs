using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class destroyer : MonoBehaviour
{

    public int a;

    void OnTriggerEnter2D(Collider2D col)
    {
            
        
            if (col.tag == "Grown")
            {
                

                PlayerPrefs.SetFloat("Speed", 1.5f);
                Application.LoadLevel(6);
            }
        

    }
}
