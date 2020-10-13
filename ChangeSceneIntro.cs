using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ChangeSceneIntro : MonoBehaviour
{
    
    public float timer;
    public int a;
    public int change;

    string gameId = "3612705";
    bool testMode = false;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    void Update()
    {
       
        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {
   
        if (timer <= 0)
        { 
            int level = PlayerPrefs.GetInt("language");

            if (level == 1)
            {
                change = 11;
            }
            else
            {
                change = 5;
            }
    
            PlayerPrefs.SetFloat("Speed", 1.5f);
            Application.LoadLevel(change);
        
            

        }

    }
}
