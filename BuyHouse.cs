using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuyHouse : MonoBehaviour
{
    public int Cost;
    public string House;
    public int scene;
    public GameObject Max;
    public GameObject Button;
    public GmeObject Panel;
    public string Ourhouse;
    
    public void BuySth()
    {
        PlayerPrefs.SetInt("Alwaysone", 1);
        if(PlayerPrefs.GetInt(Ourhouse == 1))
        {
            int money = PlayerPrefs.GetInt("balancedollars");
               if (money >= Cost)
            {
                PlayerPrefs.SetInt(House, 1);
                PlayerPrefs.SetInt("balancedollars", money - Cost);
            }
            else
            {
                SceneManager.LoadScene(scene);
            }
        }
        else
        {
            Panel.SetActive(true);
        }
    }
    void Update()
    {
        if(PlayerPrefs.GetInt(House)==1)
        {
            Max.SetActive(true);
        }
    }
}
