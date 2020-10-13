using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuy : MonoBehaviour
{
    int character;

    
    void Update()
    {
        character = PlayerPrefs.GetInt("character");

    }
}
