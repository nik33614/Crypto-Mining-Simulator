using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkbought : MonoBehaviour
{
    public GameObject buy1;
    public GameObject buy2;
    public GameObject buy3;
    public GameObject buy4;
    public GameObject buy5;

    public GameObject buy1Bought;
    public GameObject buy2Bought;
    public GameObject buy3Bought;
    public GameObject buy4Bought;
    public GameObject buy5Bought;

    void Update()
    {
        int check1 = PlayerPrefs.GetInt("pc1");
        int check2 = PlayerPrefs.GetInt("pc2");
        int check3 = PlayerPrefs.GetInt("pc3");
        int check4 = PlayerPrefs.GetInt("pc4");
        int check5 = PlayerPrefs.GetInt("pc5");

        if(check1 == 1)
        {
            buy1.SetActive(false);
            buy1Bought.SetActive(true);
        }
        if (check2 == 1)
        {
            buy2.SetActive(false);
            buy2Bought.SetActive(true);
        }
        if (check3 == 1)
        {
            buy3.SetActive(false);
            buy3Bought.SetActive(true);
        }
        if (check4 == 1)
        {
            buy4.SetActive(false);
            buy4Bought.SetActive(true);
        }
        if (check5 == 1)
        {
            buy5.SetActive(false);
            buy5Bought.SetActive(true);
        }
    }
}
