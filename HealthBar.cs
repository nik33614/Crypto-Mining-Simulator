using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public float fill;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
        fill = PlayerPrefs.GetFloat("co2");
        if (fill <= 1f)
        {
            PlayerPrefs.SetFloat("co2", 1f);
        }


    }

    // Update is called once per frame
    void Update()

    {
        fill = PlayerPrefs.GetFloat("co2");
        fill -= Time.deltaTime * 0.04f;
        bar.fillAmount = fill;
        PlayerPrefs.SetFloat("co2", fill);
    }
}
