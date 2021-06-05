using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    
    public GameObject Music_Off;
    public GameObject Music_On;
    public GameObject Fx_Off;
    public GameObject Fx_On;

    public void Click_Turn_Off_Music()
    {
        PlayerPrefs.SetInt("music", 1);
        Music_On.SetActive(false);
        Music_Off.SetActive(true);
    }

    public void Click_Turn_On_Music()
    {
        PlayerPrefs.SetInt("music", 0);
        Music_Off.SetActive(false);
        Music_On.SetActive(true);
    }

    public void Click_Turn_Off_Fx()
    {
        PlayerPrefs.SetInt("fx", 1);
        Fx_On.SetActive(false);
        Fx_Off.SetActive(true);
    }

    public void Click_Turn_On_Fx()
    {
        PlayerPrefs.SetInt("fx", 0);
        Fx_Off.SetActive(false);
        Fx_On.SetActive(true);
    }

    public void Change_to_Ru()
    {
        PlayerPrefs.SetString("language", "ru");
        //SceneManager.LoadScene(0);
    }

    public void Change_to_En()
    {
        PlayerPrefs.SetString("language", "en");
        SceneManager.LoadScene(4);
    }

    void Update()
    {
       

        if(PlayerPrefs.GetInt("music") == 1)
        {
            Music_On.SetActive(false);
            Music_Off.SetActive(true);
        }

        if (PlayerPrefs.GetInt("fx") == 1)
        {
            Fx_On.SetActive(false);
            Fx_Off.SetActive(true);
        }
    }

}
