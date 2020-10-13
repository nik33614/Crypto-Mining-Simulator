using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ChangeRackerChange : MonoBehaviour
{
    int character;
    int characterbuy;
    int characterbuy1;

    public void Change()
    {
        character = PlayerPrefs.GetInt("character");
        characterbuy = PlayerPrefs.GetInt("characterbuy1");
        characterbuy1 = PlayerPrefs.GetInt("characterbuy2");
        int level = PlayerPrefs.GetInt("language");
        Debug.Log(character);
        if (level == 1)
        {
            if (character == 1 && characterbuy == 1)
            {
                PlayerPrefs.SetInt("fl", 1);

                Application.LoadLevel(27);

            }

            if (character == 2 && characterbuy1 == 1)
            {
                PlayerPrefs.SetInt("fl", 2);

                Application.LoadLevel(29);

            }

            if (character == 0)
            {
                PlayerPrefs.SetInt("fl", 0);
                Application.LoadLevel(20);

            }


            
        }
        else
        {
            if (character == 1 && characterbuy == 1)
            {
                PlayerPrefs.SetInt("fl", 1);

                Application.LoadLevel(26);

            }
            if (character == 2 && characterbuy1 == 1)
            {
                PlayerPrefs.SetInt("fl", 2);

                Application.LoadLevel(28);

            }

            if (character == 0)
            {
                PlayerPrefs.SetInt("fl", 0);
                Application.LoadLevel(4);

            }
            
        }
        

        
    }
    
}
