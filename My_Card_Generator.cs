using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class My_Card_Generator : MonoBehaviour
{
    string card;
    public Text Card_;

    void Start()
    {
        Card();
    }

    public void Card()
    {
        if (PlayerPrefs.GetString("card") == "")
        {
            card = "7261 3300 " + Random.Range(1000, 9999).ToString()+" " + Random.Range(1000, 9999).ToString();
            StartCoroutine(Card_Check());
        }

        Card_.text = PlayerPrefs.GetString("card");
    }


    public IEnumerator Card_Check()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("card", card);
        WWW www = new WWW("https://doublenikmak.ru/4.0/Card_Check.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            if (www.text != "1")
            {
                Card();
                yield break;
            }
            else
            {
                PlayerPrefs.SetString("card", card);
                Card_.text = PlayerPrefs.GetString("card");
                yield break;
            }
        }
    }
}
