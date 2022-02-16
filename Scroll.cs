using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    public RectTransform Title;

    public RectTransform Image_;

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

            var instance_1 = GameObject.Instantiate(Image_.gameObject) as GameObject;
            instance_1.transform.SetParent(content, false);
            InitializeItemView(instance,instance_1, model);
        }
    }

    void InitializeItemView (GameObject viewGameObject,GameObject Image,TestItemModel model)
    {
        TestItemView view = new TestItemView(viewGameObject.transform);
        int len = model.title.Length;
        
        view.titleText.text = model.title.Substring(2,len-2);//.Substring(1, 4);//model.title.Length
        if(model.title.Substring(0,1) == "0")
        {
            Image.SetActive(true);
        }
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
            count = (subs.Length) - 1;
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
       // public GameObject image;
        
        public TestItemView (Transform rootView)
        {
            titleText = rootView.Find("TitleText").GetComponent<Text>();
            //image = rootView.Find("Image");
        }
    }

    public class TestItemModel
    {
        public string title;
    }
}
