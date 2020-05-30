using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInTheFlight : MonoBehaviour
{

    public float interval;

    public float timer;

    public UnityEngine.UI.Text ScoresText;

    int a = 0;

    void Start()
    {
        interval = PlayerPrefs.GetFloat("timer");
        timer = PlayerPrefs.GetFloat("timer");
    }

    void OnTriggerExit2D(Collider2D collision)
    {

        a = 1;

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Grown")
        {
            a = 0;

            timer = interval;
        }
    }

    void Update()
    {
       
        if (a == 1)
        {
            timer -= Time.deltaTime;
            

            
        }

        Debug.Log(timer);

        if (timer <= 0)
        {

            Application.LoadLevel(6);


        }

        int m = Mathf.RoundToInt(timer);

       

        string ba = m.ToString();

        

        ScoresText.text = ba + " sec";

        
    }
}


