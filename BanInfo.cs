using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BanInfo : MonoBehaviour
{
    int code;
    private IEnumerator Ban()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        WWWForm form2 = new WWWForm();
        form.AddField("code", code);
        public GameObject Panel;
        public GameObject PanelBan;

        WWW www = new WWW("http://doublenikmak.ru/User/Ban.php", form);

        yield return www;
        if (www.error != null)
        {

            Debug.Log("Произошла ошибка: " + www.error);
            yield break;


        }

        else
        {
            answer = www.text;
            PlayerPrefs.SetInt("ban",ToInt(answer));
            
            
            Debug.Log(www.text);

        }
    }
    void Start()
    {
        StartCoroutine(Ban());
        if(PlayerPrefs.GetInt("ban") == 2)
        {
            Panel.SetActive(true);
        }
        if(PlayerPrefs.GetInt("ban") == 3)
        {
            PanelBan.SetActive(true);
        }
    }
}