using UnityEngine;
using UnityEngine.Advertisements;



public class Ad : MonoBehaviour
{
    
    string gameId = "3612705";
    bool testMode = true;

    void Start()
    {
        int a = PlayerPrefs.GetInt("ad");
        Advertisement.Initialize(gameId, testMode);
        if (a >= 3)
        {
            if (Advertisement.IsReady())
            {

                Advertisement.Show();
                int ab = PlayerPrefs.GetInt("money");

                ab = ab + 1;

                PlayerPrefs.SetInt("money", ab);

                PlayerPrefs.SetInt("ad", 0);


            }
        }
    }
}
