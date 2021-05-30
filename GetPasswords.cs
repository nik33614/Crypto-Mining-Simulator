using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPasswords : MonoBehaviour
{
    private string username = "test"; //Переменная для хранения имени
	private string email = "ttest"; //Переменная для хранения почтового ящика
	private string url = "http://www.doublenikmak.ru/Users/GetEmail.php"; //Переменная для хранения адреса
	private string code = "1x1xbshweg";
	//Создание метода, отвечающего за подключение и передачу данных
	void Start()
	{
		 StartCoroutine(Connect());
	}

	private IEnumerator Connect()
	{
		WWWForm form = new WWWForm(); //Создаём новую форму 
		//Добавляем в форму новые данные
		form.AddField("username", username);
		form.AddField("email", email);
        	form.AddField("code", code);
		//Создаём новое подключение
		WWW www = new WWW(url, form);
		yield return www;
		Debug.Log(www.text);
		//Если удалось установить подключение
		if (www.isDone)
		{
			//Выводим в консоль ответ сервера
			Debug.Log("rjg");
		}
		//Если при подключении возникла ошибка
		else
		{
			//Выводим в консоль текст Error
			Debug.Log(www.text);
		}
	}
}
