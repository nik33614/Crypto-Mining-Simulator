using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject Old_Scene;
    public GameObject New_Scene;
    public GameObject Animator;

    public float time;
    private float time_update = -80;
    void Update()
    {
        if(time_update != -80)
        {
            time_update -=Time.deltaTime;
            if(time_update <= 0)
            {

                Change_Panel(true);
            }
        }
    }


    public void Change_Panel(bool check)
    {

        
        if(check == true)
        {
            New_Scene.SetActive(true);
            Animator.GetComponent<Animator>().enabled = false;
            time_update = -80;
            time = 0.5f;
            Old_Scene.SetActive(false);
        }
        else
        {
            time_update = time;
            Animator.GetComponent<Animator>().enabled = true;
           //get component and turn on anim
        }
        
    }
}
