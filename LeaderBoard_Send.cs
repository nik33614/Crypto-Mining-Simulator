using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class LeaderBoard_Send : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesPlatform.Activate();
        Social.localUser.Authenticate((bool success) =>
        {
            if (success) print("Успешно"); ;
            
        });

        int balance = PlayerPrefs.GetInt("balancedollars");
        if (balance > PlayerPrefs.GetInt("best_balancedollars"))
        {
            PlayerPrefs.SetInt("best_balancedollars", balance);
            Social.ReportScore(balance, "CgkI8P6VmtYDEAIQAA", (bool success) =>
            {
                if (success) print("Успешно");
                
            });
        }
    }

    public void LeaderBoard_UI()
    {
        Social.ShowLeaderboardUI();
    }
}
