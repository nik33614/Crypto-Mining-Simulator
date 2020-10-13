using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMoving : MonoBehaviour
{
    float Speed;

    void Update()
    {

        Speed = PlayerPrefs.GetFloat("Speed");
        Speed += 0.0005f;

        transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
        PlayerPrefs.SetFloat("Speed", Speed);
    }
   


}
