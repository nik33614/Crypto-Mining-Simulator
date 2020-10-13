using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectButon : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    public int point;
    int character;


    void Update()
    {
        character = PlayerPrefs.GetInt("character");
        Debug.Log(character);
    }

    public void Onclick()
    {
        if (point == 1)
        {
            character -= 1;
            PlayerPrefs.SetInt("character", character);
        }

        if (point == 2)
        {
            character += 1;
            PlayerPrefs.SetInt("character", character);
        }
    }
}
