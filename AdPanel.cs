using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;




public class AdPanel : MonoBehaviour
{
    string gameId = "3612705";
    bool testMode = false;

    public void Ads()
    {

        Advertisement.Initialize(gameId, testMode);

        if (Advertisement.IsReady())
        {

            Advertisement.Show();
            int ab = PlayerPrefs.GetInt("money");

            ab = ab + 5;

            PlayerPrefs.SetInt("money", ab);




        }
    }
}

