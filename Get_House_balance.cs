using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_House_balance : MonoBehaviour
{
    int code;
    int balance;
    int house = 0;

    public void Click()
    {
        StartCoroutine(Send());
    }

    private IEnumerator Send()
    {
        code = PlayerPrefs.GetInt("code");
        balance = PlayerPrefs.GetInt("balancedollars");
        int house1 = PlayerPrefs.GetInt("house1");
        int house2 = PlayerPrefs.GetInt("house2");
        int house3 = PlayerPrefs.GetInt("house3");
        if (house1 == 1)
        {
            house = 1;
        }
        if (house2 == 1)
        {
            house = 2;
        }
        if (house3 == 1)
        {
            house = 3;
        }
        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("balance", balance);
        form.AddField("house", house);
        WWW www = new WWW("http://doublenikmak.ru/Get_House_balance.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            Debug.Log(www.text);
        }
    }
}
