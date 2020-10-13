using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMoveSky : MonoBehaviour
{
    float Speed;
    float a = 1f;

    void Update()
    {
        Speed = PlayerPrefs.GetFloat("Speed");
        if(Speed == 0)
        {
            Speed = a;
        }
        Speed -= a;
        transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Accelerator")
        {
            Speed += 0.5f;

            PlayerPrefs.SetFloat("Speed", Speed);

        }


    }
}
