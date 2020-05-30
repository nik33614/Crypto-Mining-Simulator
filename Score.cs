using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float timer = 0;
    public UnityEngine.UI.Text ScoresText;
    public string a;

     void Start()
    {
        timer = PlayerPrefs.GetInt("scorenow");
    }

    void Update()
    {
        

        float plus = PlayerPrefs.GetFloat("Speed");

        timer = timer + plus * Time.deltaTime;

       

        int m = Mathf.RoundToInt(timer);

        PlayerPrefs.SetInt("scorenow", m);

        a = m.ToString();

        a = a + " m";

        ScoresText.text = a;

    }
            
       
}
