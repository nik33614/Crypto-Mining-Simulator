using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCar : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    public GameObject buy1Boughtcar;
    public GameObject buy2Boughtcar;
    public GameObject buy3Boughtcar;
    public GameObject buy4Boughtcar;

    void Update()
    {
        int check1car = PlayerPrefs.GetInt("car1");
        int check2car = PlayerPrefs.GetInt("car2");
        int check3car = PlayerPrefs.GetInt("car3");
        int check4car = PlayerPrefs.GetInt("car4");

        if (check1car == 1)
        {
            car1.SetActive(false);
            buy1Boughtcar.SetActive(true);
        }
        if (check2car == 1)
        {
            car2.SetActive(false);
            buy2Boughtcar.SetActive(true);
        }
        if (check3car == 1)
        {
            car3.SetActive(false);
            buy3Boughtcar.SetActive(true);
        }
        if (check4car == 1)
        {
            car4.SetActive(false);
            buy4Boughtcar.SetActive(true);
        }
    }
}
