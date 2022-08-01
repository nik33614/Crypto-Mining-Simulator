using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Applications : MonoBehaviour
{
    float timel = 0.5f;
    float timer;
    private GameObject Old_Application;
    public GameObject New_Application;
    private Animation anim;
    public string Name_Anim = "Close";
    int a;
    int y;
    bool m = false;

    string[] hier = { "Browser_Ap", "Performance_Background", "Bank_Ap", "Settings_Ap","Traiding_Ap", "Core_Ap", "Graphic_Ap", "MotherBoard_Ap", "Power_Ap", "Cooler_Ap", "House_Ap", "Leaderboard_Ap", "Shop_Ap" };

    void Start()
    {
        a = 0;
        y = 0;
        m = false;
    }

    void Update()
    {
        if (a == 1)
        {
            Old_Application.GetComponent<Animation>().Play(Name_Anim);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                New_Application.SetActive(true);
                a = 0;
                y = 0;
                m = false;
                Old_Application.SetActive(false);
                timer = timel;

            }
        }
    }
    public void Change()
    {
        foreach (string ob in hier)
        {
            y++;
            if (GameObject.Find(ob) == true)
            { 
                Old_Application = GameObject.Find(ob);
                m = true;
            }
        }
        Debug.Log(y);
        Debug.Log(m);
        if(y == 12 && m == false)
        {
            New_Application.SetActive(true);
        }
        else
        {
            timer = timel;
            a = 1;
        }
    }
}
