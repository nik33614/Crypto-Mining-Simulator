using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    public RectTransform Title;

    public RectTransform content;
    int code;
    int type;
    int count;
    string[] subs;
    string[] sub;
    

void Start()
{
    StartCoroutine(GetInf(results => OnReceivedModels(results)));
}

    void OnReceivedModels (TestItemModel[] models)
    {
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }

        foreach (var model in models)
        {
            var instance = GameObject.Instantiate(Title.gameObject) as GameObject;
            instance.transform.SetParent(content, false);
            InitializeItemView(instance, model);
        }
    }

    void InitializeItemView (GameObject viewGameObject, TestItemModel model)
    {
        TestItemView view = new TestItemView(viewGameObject.transform);
        view.titleText.text = model.title;//.Substring(1, 4);//model.title.Length
    }
    IEnumerator GetInf(System.Action<TestItemModel[]> callback)
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", "000001");
        form.AddField("type", type);

        WWW www = new WWW("http://doublenikmak.ru/Mails/Mail.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
            callback(null);
        }
        else
        {
            string answer = www.text;
            sub = answer.Split('|');
            var tmp = new List<string>(sub);
            tmp.RemoveAt(0); 
            subs  = tmp.ToArray(); 
            count = subs.Length;
            var results = new TestItemModel[count];
            
            for (int i = 0; i < count; i++)
            {
                results[i] = new TestItemModel();
                results[i].title = subs[i].ToString();
            }
            callback(results);
        }
    } 

    public class TestItemView
    {
        public Text titleText;
        
        public TestItemView (Transform rootView)
        {
            titleText = rootView.Find("TitleText").GetComponent<Text>();
        }
    }

    public class TestItemModel
    {
        public string title;
    }
}
