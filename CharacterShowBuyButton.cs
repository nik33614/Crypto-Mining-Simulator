using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShowBuyButton : MonoBehaviour
{
    int character;
    public int cost;
    public int chracterbuy;
    public int chracterbuy1;
    public GameObject button;
    public GameObject button1;
    int balance;

    void Update()
    {
        character = PlayerPrefs.GetInt("character");
        chracterbuy = PlayerPrefs.GetInt("characterbuy1");
        chracterbuy1 = PlayerPrefs.GetInt("characterbuy2");

        if (character == 1 && chracterbuy == 0)
        {
            button1.SetActive(false);
            //Debug.Log("gg");
            button.SetActive(true);
        }
        if (character == 2 && chracterbuy1 == 0)
        {
            button.SetActive(false);
            button1.SetActive(true);
        }
        if(character==0)
        {
            button.SetActive(false);
            button1.SetActive(false);
        }
        if(character == 1 && chracterbuy == 1)
        {
            button1.SetActive(false);
            button.SetActive(false);
        }
        if(character == 2 && chracterbuy1 == 1)
        {
            button.SetActive(false);
            button1.SetActive(false);
        }

        //Debug.Log(PlayerPrefs.GetInt("costcharacter"));
    }

    public void Click()
    {

        if (character == 1)
        {
            cost = 500;
        }
        if (character == 2)
        {
            cost = 1500;
        }
        balance = PlayerPrefs.GetInt("money");


        if (balance >= cost)
        {

            balance -= cost;
            if (character == 1)
            {
                PlayerPrefs.SetInt("characterbuy1", 1);
                PlayerPrefs.SetInt("money", balance);
            }
            else
            {
                PlayerPrefs.SetInt("characterbuy2", 1);
                PlayerPrefs.SetInt("money", balance);
            }
        }
    }

}
