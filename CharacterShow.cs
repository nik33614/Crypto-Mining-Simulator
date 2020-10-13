using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShow : MonoBehaviour
{
    int character;
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;


    void Update()
    {
        character = PlayerPrefs.GetInt("character");
        if(character == 0)
        {
            character1.SetActive(true);
            character2.SetActive(false);
            character3.SetActive(false);

            point1.SetActive(false);
            point2.SetActive(true);
            //point3.SetActive(false);
        }
        if (character == 1)
        {
            character2.SetActive(true);
            character1.SetActive(false);
            character3.SetActive(false);

            point2.SetActive(true);
            point1.SetActive(true);
            //point3.SetActive(false);

        }
        if (character == 2)
        {
            character2.SetActive(false);
            character1.SetActive(false);
            character3.SetActive(true);
            point2.SetActive(false);
            point1.SetActive(true);
            //point3.SetActive(true);
        }
    }
}
