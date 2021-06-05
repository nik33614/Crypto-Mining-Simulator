using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuyCar : MonoBehaviour
{
    public int Cost;
    public string Car;
    public int scene;

    public void BuySth()
    {
        int money = PlayerPrefs.GetInt("balancedollars");
        if (money >= Cost)
        {
            PlayerPrefs.SetInt(Car, 1);
            PlayerPrefs.SetInt("balancedollars", money - Cost);
        }
        else
        {
            SceneManager.LoadScene(scene);
        }
    }
}
