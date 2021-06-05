using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHouse : MonoBehaviour
{
    public GameObject house1;
    public GameObject house2;
    public GameObject house3;
    public GameObject house4;

    public GameObject buy1Boughthouse;
    public GameObject buy2Boughthouse;
    public GameObject buy3Boughthouse;
    public GameObject buy4Boughthouse;


    void Update()
    {

        int check1house = PlayerPrefs.GetInt("house1");
        int check2house = PlayerPrefs.GetInt("house2");
        int check3house = PlayerPrefs.GetInt("house3");
        int check4house = PlayerPrefs.GetInt("house4");
        int check5house = PlayerPrefs.GetInt("house5");

        if (check1house == 1)
        {
            house1.SetActive(false);
            buy1Boughthouse.SetActive(true);
        }
        if (check2house == 1)
        {
            house2.SetActive(false);
            buy2Boughthouse.SetActive(true);
        }
        if (check3house == 1)
        {
            house3.SetActive(false);
            buy3Boughthouse.SetActive(true);
        }
        if (check4house == 1)
        {
            house4.SetActive(false);
            buy4Boughthouse.SetActive(true);
        }
    }
}
