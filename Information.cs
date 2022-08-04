using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    public Text Name;
    public Text Place;
    public Text Money;
    public Text Next_Place;
    

    void Start()
    {
        StartCoroutine(GetInf());
    }
    public IEnumerator GetInf()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Show_Leaderboard_Information.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            string[] delimiterChars = { "~" };
            string[] words = www.text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            int a = 0;
            foreach (var word in words)
            {
                
                switch (a)
                {
                    
                    case 0:
                        Name.text = word;
                        break;
                    case 1:
                        Place.text = "Your place - " + word;
                        break;
                    case 2:
                        Money.text = "Earned - " + word+"$";
                        break;
                    case 3:
                        Next_Place.text = "To the next place - "+word + "$";
                        break;
                }
                a ++;
            }
            yield break;
        }
    }
}
