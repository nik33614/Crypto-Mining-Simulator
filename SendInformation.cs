using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SendInformation : MonoBehaviour
{

    int code;
    int pc;

    void Start()
    {
            StartCoroutine(Send()); 
    }

    private IEnumerator Send()
    {
        code = PlayerPrefs.GetInt("code");
        WWWForm form = new WWWForm();
        
        form.AddField("code", code);
        form.AddField("check", 1);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            Debug.Log(www.text);
            PlayerPrefs.SetFloat("profitsec",float.Parse(www.text));
            StartCoroutine(Send1());
        }
    }
    private IEnumerator Send1()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 2);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetFloat("balance", float.Parse(www.text));
            StartCoroutine(Send2());
        }
    }
    private IEnumerator Send2()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 3);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
            StartCoroutine(Send3());
        }
    }
    private IEnumerator Send3()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 4);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            pc = Convert.ToInt32(www.text);
            string strpc = "pc" + www.text;
            PlayerPrefs.SetInt(strpc, 1);
            StartCoroutine(Send4());
        }
    }
    private IEnumerator Send4()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 5);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            string house = "house" + www.text;
            PlayerPrefs.SetInt(house, 1);
            StartCoroutine(Send4());
            StartCoroutine(Send5());
        }
    }
    private IEnumerator Send5()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 6);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            string partcpu = "CPU_upgrade_PC" + pc.ToString();
            PlayerPrefs.SetInt(partcpu, Convert.ToInt32(www.text));
            StartCoroutine(Send6());
        }
    }
    private IEnumerator Send6()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 7);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            string partcpu = "Power_Supply_upgrade_PC" + pc.ToString();
            PlayerPrefs.SetInt(partcpu, Convert.ToInt32(www.text));
            StartCoroutine(Send7());
        }
    }

    private IEnumerator Send7()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 8);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            string partcpu = "Mother_Board_upgrade_PC" + pc.ToString();
            PlayerPrefs.SetInt(partcpu, Convert.ToInt32(www.text));
            StartCoroutine(Send8());

        }
    }
    private IEnumerator Send8()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 9);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            string partcpu = "Graphic_Card_upgrade_PC" + pc.ToString();
            PlayerPrefs.SetInt(partcpu, Convert.ToInt32(www.text));

            StartCoroutine(Send9());
        }
    }
    private IEnumerator Send9()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 10);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            
            PlayerPrefs.SetInt("fanupgrade", Convert.ToInt32(www.text));

            StartCoroutine(Send10());
        }
    }
    private IEnumerator Send10()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 11);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("fan_timer", Convert.ToInt32(www.text));

            StartCoroutine(Send11());
        }
    }
    private IEnumerator Send11()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", code);
        form.AddField("check", 12);

        WWW www = new WWW("http://doublenikmak.ru/SendInformation.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetFloat("profitold", float.Parse(www.text));
            

        }
    }
}
