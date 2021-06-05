using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skript : MonoBehaviour
{
    
    public float timer;

    void Start()
    {

        Resolution[] resolutions = Screen.resolutions;
        
       
        foreach (var res in resolutions)
        {
            if (res.width <= 1000 && res.height <= 1870)
            {
                PlayerPrefs.SetInt("scenemanager", 0);
                SceneManager.LoadScene(31);
            }
            if (res.width > 1000 && res.height > 1870 && res.width < 1100 && res.height < 2350)
            {
                PlayerPrefs.SetInt("scenemanager", 1);
                SceneManager.LoadScene(8);
            }
            if (res.width >= 1100 && res.height >= 2350 && res.width < 1400 && res.height < 2400)
            {
                PlayerPrefs.SetInt("scenemanager", 2);
                SceneManager.LoadScene(30);
            }
            if (res.width >= 1400 && res.height >= 2400)
            {
                PlayerPrefs.SetInt("scenemanager", 3);
                SceneManager.LoadScene(32);
            }
        }


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
            SceneManager.LoadScene(31);
        }

    }
} 