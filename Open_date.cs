using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_date : MonoBehaviour
{
   public float timer = 1.5f;

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Plus();
        }
    }
    void Plus()
    {
        StartCoroutine(Checks());
    }
    private IEnumerator Checks()
    {
        
        WWWForm form = new WWWForm();
        
        WWW www = new WWW("http://doublenikmak.ru/Leaderboard/date.php", form);

        yield return www;
        
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            yield break;
        }       
    }
}