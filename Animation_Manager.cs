using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Manager : MonoBehaviour
{
    float timel = 0.5f;
    float timer;
    public GameObject object_;
    private Animation anim;
    public string Name_Anim;
    public bool Type = false;
    public bool Start_ = false;
    public GameObject Old;

    void Start()
    {
        timer = timel; 
    }

    void Update()
    {
        if (Type == false)
        {
            object_.GetComponent<Animation>().Play(Name_Anim);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                object_.SetActive(false);
                gameObject.SetActive(false);
                timer = timel;
                Type = false;
            }
        }
        if (Type == true && Start_ == true)
        {
            Old.GetComponent<Animation>().Play(Name_Anim);
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                object_.SetActive(true);
                Old.SetActive(false);
                timer = timel;
              
                Start_ = false;
            }
        }
    }
    public void Change()
    {
       
        Start_ = true;
    }
}
