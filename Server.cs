using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Server : MonoBehaviour
{
    public string money = "";
    public string phone = "";

    void Start()
    {
        StartCoroutine(GET());
        StartCoroutine(Vovod());
    }
   
    private IEnumerator Vovod()
    {
        WWWForm form = new WWWForm();
        form.AddField("cost1", 2);
        

        WWW www = new WWW("http://doublenikmak.ru/Test.php", form);

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

    public IEnumerator GET()
    {
	    int data1 = 2;
	    
	    WWW Query = new WWW("http://doublenikmak.ru/Test.php?cost1=" + data1);
	    yield return Query;
	    if (Query.error != null)
	    {
		    Debug.Log("Server does not respond : " + Query.error);
	    }
	    else
	    {
		    if (Query.text != null) // что нам должен ответить сервер на наши данные
		    {
			    Debug.Log("Server responded correctly");
		    }
		    else
		    {
		    	Debug.Log("Server responded : " + Query.text);
		    }
	    }
	    Query.Dispose();
	}
}
