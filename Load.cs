using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    float timer = 0f;
    float time = 0f;
    public Image Load_Image;
    float profit;
    float num;
    float fill;
    float num_prof;
    float num_max;
    void Start()
    {
       Debug.Log(PlayerPrefs.GetFloat("profit"));
    }

    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        time -= Time.deltaTime;
        if(timer < 0f)
        {
          
            profit = Random.Range((float)(PlayerPrefs.GetFloat("profit") - PlayerPrefs.GetFloat("profit") * 0.4), (float)(PlayerPrefs.GetFloat("profit") + PlayerPrefs.GetFloat("profit") * 0.4));
            num_max = PlayerPrefs.GetFloat("profit") * 2;
            num = profit / num_max;
            timer = 3f;
        }
        float g = num - fill;

        fill = Load_Image.fillAmount;
        num_prof = fill + g * 0.008f;

        Load_Image.fillAmount = num_prof;
        //Debug.Log(num_prof * num_max);
        //Debug.Log(PlayerPrefs.GetFloat("profit") * 2);
        if (time < 0f)
        {
            
            if(num_prof*num_max > PlayerPrefs.GetFloat("profit")*2)
            {
                //Debug.Log(PlayerPrefs.GetFloat("profit") * 2);
                PlayerPrefs.SetFloat("bitcoin", PlayerPrefs.GetFloat("bitcoin") + PlayerPrefs.GetFloat("profit") * 2);
            }
            else
            {
                //Debug.Log(num_prof * num_max);
                PlayerPrefs.SetFloat("bitcoin", PlayerPrefs.GetFloat("bitcoin") + num_prof * num_max);
            }
            
            time = 1f;
        }
        
        
    }

    public void Click()
    {
        profit = num_max;
        num = profit / num_max;
        timer = 1f;
    }
}