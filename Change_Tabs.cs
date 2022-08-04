using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Tabs : MonoBehaviour
{
    
    float timel = 0.5f;
    float timer;
    int a = 0;

    public GameObject New_Scene;
    public GameObject Old_Scene;
    private Animation anim;
    private string Name_Anim;

    void Start()
    {
        a = 0;
        timer = timel;
    }

    void Update()
    {
        if (a == 1)
        {


            Old_Scene.GetComponent<Animation>().Play("Close");
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                New_Scene.SetActive(true);
                a = 0;
                Old_Scene.SetActive(false);
                timer = timel;
            }
        }
    }
    public void Change()
    {
        a = 1;
        timer = timel;
    }
}
