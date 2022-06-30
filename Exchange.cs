using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Exchange : MonoBehaviour
{
    public Text Rate_;
    public Text Give;
    public Text Get;
    private int Rate;
    public Slider Slider_;

    void Start()
    {
        StartCoroutine(Course_Get());
        Slider_.maxValue = (float)Math.Round(PlayerPrefs.GetFloat("bitcoin"), 2);
        Slider_.value = (float)Math.Round(PlayerPrefs.GetFloat("bitcoin") / 2, 2);
        Give.text = Math.Round(Slider_.value, 2).ToString()+ "₿";
    }

    public IEnumerator Course_Get()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        WWW www = new WWW("https://doublenikmak.ru/4.0/Rate.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Rate_.text = "1₿ = " + www.text+"$";
            Rate = Convert.ToInt32(www.text);
            Get.text = Convert.ToInt32(Math.Round(Slider_.value, 2) * Rate).ToString() + "$";
            yield break;
        }
    }
    public void Find_Exchange()
    {
        Give.text = Math.Round(Slider_.value, 2).ToString()+ "₿";
        Get.text = Convert.ToInt32(Math.Round(Slider_.value, 2)*Rate).ToString()+"$";
    }
}
