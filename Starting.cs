using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
    public GameObject BackGround_1_Light;
    public GameObject BackGround_1_Dark;

    public GameObject BackGround_2_Light;
    public GameObject BackGround_2_Dark;

    public GameObject BackGround_3_Light;
    public GameObject BackGround_3_Dark;

    public GameObject BackGround_4_Light;
    public GameObject BackGround_4_Dark;

    public GameObject BackGround_5_Light;
    public GameObject BackGround_5_Dark;

    public GameObject BackGround_6_Light;
    public GameObject BackGround_6_Dark;

    public GameObject Performance_Dark;
    public GameObject Performance_Light;
    void Start()
    {
        System.DateTime moment = new System.DateTime();
        int hour = moment.Hour;
        switch (PlayerPrefs.GetInt("background"))//задний фон полный
        {
            case 1:
                if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
                {
                    BackGround_1_Dark.SetActive(true);
                    BackGround_1_Light.SetActive(false);
                }
                else
                {
                    BackGround_1_Light.SetActive(true);
                    BackGround_1_Dark.SetActive(false);
                }
                break;
            case 2:
                if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
                {
                    BackGround_2_Dark.SetActive(true);
                    BackGround_2_Light.SetActive(false);
                }
                else
                {
                    BackGround_2_Light.SetActive(true);
                    BackGround_2_Dark.SetActive(false);
                }
                break;
            case 3:
                if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
                {
                    BackGround_3_Dark.SetActive(true);
                    BackGround_3_Light.SetActive(false);
                }
                else
                {
                    BackGround_3_Light.SetActive(true);
                    BackGround_3_Dark.SetActive(false);
                }
                break;
            case 4:
                if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
                {
                    BackGround_4_Dark.SetActive(true);
                    BackGround_4_Light.SetActive(false);
                }
                else
                {
                    BackGround_4_Light.SetActive(true);
                    BackGround_4_Dark.SetActive(false);
                }
                break;
            case 5:
                if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
                {
                    BackGround_5_Dark.SetActive(true);
                    BackGround_5_Light.SetActive(false);
                }
                else
                {
                    BackGround_5_Light.SetActive(true);
                    BackGround_5_Dark.SetActive(false);
                }
                break;
            case 6:
                if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
                {
                    BackGround_6_Dark.SetActive(true);
                    BackGround_6_Light.SetActive(false);
                }
                else
                {
                    BackGround_6_Light.SetActive(true);
                    BackGround_6_Dark.SetActive(false);
                }
                break;
        }
        if ((hour >= 19 && hour <= 23) || hour >= 0 && hour <= 5)
        {
            Performance_Dark.SetActive(true);
            Performance_Light.SetActive(false);
        }
        else
        {
            Performance_Dark.SetActive(false);
            Performance_Light.SetActive(true);
        }
    }
}