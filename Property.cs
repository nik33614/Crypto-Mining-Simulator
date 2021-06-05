using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour
{
    public GameObject buy1;
    public GameObject buy2;
    public GameObject buy3;
    public GameObject buy4;
    public GameObject buy5;
    public GameObject buy0;

    public GameObject house1;
    public GameObject house2;
    public GameObject house3;
    public GameObject house4;
    public GameObject house0;

    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;
    public GameObject car0;

    void Start()
    {
        if(PlayerPrefs.GetInt("pc1") == 1)
        {
            buy1.SetActive(true);
            buy2.SetActive(false);
            buy3.SetActive(false);
            buy4.SetActive(false);
            buy5.SetActive(false);
        }
        if(PlayerPrefs.GetInt("pc2") == 1)
        {
            buy2.SetActive(true);
            buy1.SetActive(false);
            
            buy3.SetActive(false);
            buy4.SetActive(false);
            buy5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("pc3") == 1)
        {
            buy1.SetActive(false);
            buy2.SetActive(false);
            buy3.SetActive(true);
            buy4.SetActive(false);
            buy5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("pc4") == 1)
        {
            buy1.SetActive(false);
            buy2.SetActive(false);
            buy3.SetActive(false);
            buy4.SetActive(true);
            buy5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("pc5") == 1)
        {
            buy1.SetActive(false);
            buy2.SetActive(false);
            buy3.SetActive(false);
            buy4.SetActive(false);
            buy5.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("profitsec") == 0)
        {
            buy0.SetActive(true);
        }

        if (PlayerPrefs.GetInt("house1") == 1)
        {
            house1.SetActive(true);
            house2.SetActive(false);
            house3.SetActive(false);
            house4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("house2") == 1)
        {
            house1.SetActive(false);
            house2.SetActive(true);
            house3.SetActive(false);
            house4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("house3") == 1)
        {
            house1.SetActive(false);
            house2.SetActive(false);
            house3.SetActive(true);
            house4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("house4") == 1)
        {
            house1.SetActive(false);
            house2.SetActive(false);
            house3.SetActive(false);
            house4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("house1") == 0 && PlayerPrefs.GetInt("house2") == 0 && PlayerPrefs.GetInt("house3") == 0 && PlayerPrefs.GetInt("house4") == 0)
        {
            house0.SetActive(true);
        }

        if (PlayerPrefs.GetInt("car1") == 1)
        {
            car1.SetActive(true);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("car2") == 1)
        {
            car1.SetActive(false);
            car2.SetActive(true);
            car3.SetActive(false);
            car4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("car3") == 1)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(true);
            car4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("car4") == 1)
        {
            car1.SetActive(false);
            car2.SetActive(false);
            car3.SetActive(false);
            car4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("car1") == 0 && PlayerPrefs.GetInt("car2") == 0 && PlayerPrefs.GetInt("car3") == 0 && PlayerPrefs.GetInt("car4") == 0)
        {
            car0.SetActive(true);
        }
    }

}
