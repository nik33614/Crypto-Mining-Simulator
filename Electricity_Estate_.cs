using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Electricity_Estate_ : MonoBehaviour
{
    /// <summary>
    /// �������� � ������� �����
    /// 
    /// </summary>
    /// 
    public Text Electricity;
    public Text Estate;

    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            StartCoroutine(Data_Estate());
            StartCoroutine(Data_Electricity());
            timer = 20f;
        }
    }
    public IEnumerator Data_Estate()//�������� ����� �� �������, ���������� ��� � ���, ������� � ���� ������, � �������� ��������(1 ���� - ������ ���� ���� � ��)
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//��������� ���� � ������� � ������������� ����� � ��������

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Estate.text = www.text;

            PlayerPrefs.SetInt("Estate_debt", Convert.ToInt32(www.text));
            yield break;

        }
    }
    public IEnumerator Data_Electricity()//�������� ����� �� �������, ���������� ��� � ���, ������� � ���� ������, � �������� ��������(1 ���� - ������ ���� ���� � ��)
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//��������� ���� � ������� � ������������� ����� � ��������

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Electricity.text = www.text;
            yield break;

        }
    }
    public void Pay_Est()
    {
        if(PlayerPrefs.GetInt("dollars")>=PlayerPrefs.GetInt("Estate_debt"))
        {
            PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - PlayerPrefs.GetInt("Estate_debt"));
            StartCoroutine(Send_Est());
        }
    }
    public void Pay_El()
    {
        if (PlayerPrefs.GetInt("dollars") >= PlayerPrefs.GetFloat("Electricity_debt"))
        {
            PlayerPrefs.SetInt("dollars", PlayerPrefs.GetInt("dollars") - Convert.ToInt32(PlayerPrefs.GetFloat("Electricity_debt")));
            StartCoroutine(Send_El());
        }
    }
    public IEnumerator Send_Est()//�������� ����� �� �������, ���������� ��� � ���, ������� � ���� ������, � �������� ��������(1 ���� - ������ ���� ���� � ��)
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("balance", PlayerPrefs.GetInt("dollars").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//��������� ���� � ������� � ������������� ����� � ��������

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Electricity.text = www.text;
            yield break;

        }
    }
    public IEnumerator Send_El()//�������� ����� �� �������, ���������� ��� � ���, ������� � ���� ������, � �������� ��������(1 ���� - ������ ���� ���� � ��)
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("balance", PlayerPrefs.GetInt("dollars").ToString());

        WWW www = new WWW("https://doublenikmak.ru/4.0/Data_Time.php", form);//��������� ���� � ������� � ������������� ����� � ��������

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            Electricity.text = www.text;
            yield break;

        }
    }
}
