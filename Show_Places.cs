using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Places : MonoBehaviour
{
    public Text Place_1;
    public Text Place_2;
    public Text Place_3;
    public Text Place_4;
    public Text Place_5;
    public Text Place_6;

    void Start()
    {
        StartCoroutine(GetPlaces());
    }
    public IEnumerator GetPlaces()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Show_Places.php", form);

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
                        Place_1.text = word;
                        break;
                    case 1:
                        Place_2.text = word;
                        break;
                    case 2:
                        Place_3.text = word;
                        break;
                    case 3:
                        Place_4.text = word;
                        break;
                    case 4:
                        Place_5.text = word;
                        break;
                    case 5:
                        Place_6.text = word;
                        break;
                }
                a += 1;
            }
            yield break;
        }
    }
}