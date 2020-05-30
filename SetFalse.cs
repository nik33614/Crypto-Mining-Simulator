using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFalse : MonoBehaviour
{

    public GameObject start;
    




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Changer")
        {
            start.SetActive(true);

            
        }

    }

}
