using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMoveSky : MonoBehaviour
{
    float Speed = PlayerPrefs.GetFloat("Speed");

    void Update()
    {
        Speed = PlayerPrefs.GetFloat("Speed");
        Speed -=  1f;
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
