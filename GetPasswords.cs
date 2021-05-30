using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SendEmail : MonoBehaviour
{
	private string username; 
	private string email; 
	private string url = "http://www.doublenikmak.ru/Users/GetEmail.php"; 
	private string code;
	public GameObject PanelEm;

	//Создание объекта для генерации чисел
	Random rnd = new Random();
 
//Получить случайное число (в диапазоне от 0 до 10)

	void Start()
	{
		PlayerPrefs.SetInt("code",rnd.Next(1000000, 9999999));
		if (PlayerPrefs.GetInt("TutorialEmail") == 0)
		{
			PanelEm.SetActive(true);
		}
		

	}

	public void Email()
	{
		PlayerPrefs.SetString("email",email);
	}

	public void Send()
    {
		StartCoroutine(Connect());
	}

	private IEnumerator Connect()
	{
		WWWForm form = new WWWForm(); 

		form.AddField("username", PlayerPrefs.GetString("nickname"));
		form.AddField("email", PlayerPrefs.GetString("email"));
		form.AddField("code", PlayerPrefs.GetInt("code"));
		
		WWW www = new WWW(url, form);
		yield return www;
		Debug.Log(www.text);
	
		if (www.isDone)
		{
			Debug.Log("Ok");
		}

		else
		{
			Debug.Log(www.text);
		}
		PlayerPrefs.SetInt("TutorialEmail", 1);
	}
}