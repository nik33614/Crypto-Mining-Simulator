using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    int language;
    int change;
    
    void Update()
    {
        language = PlayerPrefs.GetInt("language");
    }

    public void languages()

    {
        
        if(language == 0)
        {
            language += 1;
           PlayerPrefs.SetInt("language", language);
            Application.LoadLevel(13);

            
        }
        
        if (language == 1)
        {
            language -= 1;
            PlayerPrefs.SetInt("language", language);

            
                Application.LoadLevel(7);
            
        }
        

    }
   
}
