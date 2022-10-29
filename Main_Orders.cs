//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    /// <summary>
    /// Gets Title and content
    /// </summary>
    public Text Title_1;
    public Text Title_2;
    public Text Title_3;

    public Text Content_1;
    public Text Content_2;
    public Text Content_3;

    public Image Ava_1;
    public Image Ava_2;
    public Image Ava_3;

    public Sprite Guy_1;
    public Sprite Guy_2;
    public Sprite Guy_3;
    public Sprite Guy_4;
    public Sprite Guy_5;

    public Text CountDown_1;
    public Text CountDown_2;
    public Text CountDown_3;

    bool Count = false;

    List<string> tmp = new List<string>();

    void Start()//check started and ende tasks and make zerofying
    {
        Update_Button();
    }

    void OnReceivedModels()
    {
        for (int i = 0; i < tmp.Count; i++)
        {
            if (i == 0)
            {
                var con_in = new List<string>(tmp[i].Split('*'));
                if (con_in[0] == "null")
                {
                    Title_1.text = "";
                    Content_1.text = "Nothing for now";
                    Ava_1.sprite = Guy_5;
                }
                else
                {
                    Title_1.text = con_in[0];
                    Content_1.text = con_in[1];
                    PlayerPrefs.SetInt("case_1", System.Convert.ToInt32(con_in[2]));
                  
                    
                    int ava = Random.Range(0, 4);
                    switch (ava)
                    {
                        case 0:
                            Ava_1.sprite = Guy_1;
                            break;
                        case 1:
                            Ava_1.sprite = Guy_2;
                            break;
                        case 2:
                            Ava_1.sprite = Guy_3;
                            break;
                        case 3:
                            Ava_1.sprite = Guy_4;
                            break;
                    }
                }
            }
            if (i == 1)
            {
                var con_in = new List<string>(tmp[i].Split('*'));
                if (con_in[0] == "null")
                {
                    Title_2.text = "";
                    Content_2.text = "Nothing for now";
                    Ava_2.sprite = Guy_5;
                }
                else
                {
                    Title_2.text = con_in[0];
                    Content_2.text = con_in[1];
                    PlayerPrefs.SetInt("case_2", System.Convert.ToInt32(con_in[2]));
                    int ava = Random.Range(0, 4);
                    switch (ava)
                    {
                        case 0:
                            Ava_2.sprite = Guy_1;
                            break;
                        case 1:
                            Ava_2.sprite = Guy_2;
                            break;
                        case 2:
                            Ava_2.sprite = Guy_3;
                            break;
                        case 3:
                            Ava_2.sprite = Guy_4;
                            break;
                    }
                }
            }
            if (i == 2)
            {
                var con_in = new List<string>(tmp[i].Split('*'));
                if (con_in[0] == "null")
                {
                    Title_3.text = "";
                    Content_3.text = "Nothing for now";
                    Ava_3.sprite = Guy_5;
                }
                else
                {
                    Title_3.text = con_in[0];
                    Content_3.text = con_in[1];
                    PlayerPrefs.SetInt("case_3", System.Convert.ToInt32(con_in[2]));
                    int ava = Random.Range(0, 4);
                    switch (ava)
                    {
                        case 0:
                            Ava_3.sprite = Guy_1;
                            break;
                        case 1:
                            Ava_3.sprite = Guy_2;
                            break;
                        case 2:
                            Ava_3.sprite = Guy_3;
                            break;
                        case 3:
                            Ava_3.sprite = Guy_4;
                            break;
                    }
                }
            }
        }
    }

    private IEnumerator GetInf()//gets 3 tasks from the server
    {
        string[] subs;
        string[] sub;

        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("https://doublenikmak.ru/4.0/Get_Orders.php", form))
        {

            AcceptAllCertificatesSignedWithASpecificKeyPublicKey amazonCertificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
            www.certificateHandler = amazonCertificateHandler;
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();


            if (www.isNetworkError)
            {
                Debug.Log("Error");
                yield break;
                
            }
            else
            {
                string answer = www.downloadHandler.text;

                sub = answer.Split('|');
                tmp = new List<string>(sub);


                OnReceivedModels();
                
                subs = tmp.ToArray();

                yield break;
            }
        }
    }
    public void Update_Button()
    {
        StartCoroutine(GetInf());
    }
    public void Start_Order(int which)
    {
        ///start countdown+
        ///checks case_+which nunmber+
        ///start each mission
        ///+send to server inf of start+
        PlayerPrefs.SetFloat("timer_module", 600f);
        Count = true;
        string ToSearch = "case_" + which.ToString();
        int to_case = PlayerPrefs.GetInt(ToSearch);
        switch (to_case)
        {
            ///to  write for each case what we doo
            case 1:
                int a = 1 + 1;
                break;

        }
        StartCoroutine(Send_Inf_Start(which));


    }

    public IEnumerator Send_Inf_Start(int which)
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());
        form.AddField("case", which.ToString());
        using (UnityWebRequest www = UnityWebRequest.Post("https://doublenikmak.ru/4.0/Get_Orders.php", form))
        {

            AcceptAllCertificatesSignedWithASpecificKeyPublicKey amazonCertificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
            www.certificateHandler = amazonCertificateHandler;
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();


            if (www.isNetworkError)
            {
                Debug.Log("Error");
                yield break;
            }
            else
            {
                yield break;
            }
        }
    }



    void FixedUpdate()//updates timer
    {
        int module = 0;
        if (Count == true)
        {
            
            if (PlayerPrefs.GetInt("case_1") != 0)
            {
                module = 0;
            }
            if (PlayerPrefs.GetInt("case_2") != 0)
            {
                module = 1;
            }
            if (PlayerPrefs.GetInt("case_3") != 0)
            {
                module = 2;
            }

            float timer = PlayerPrefs.GetFloat("timer_module") - Time.deltaTime;
            if (timer > 0)
            {
                switch (module)
                {
                    case 0:
                        CountDown_1.text = timer.ToString();
                        break;
                    case 1:
                        CountDown_2.text = timer.ToString();
                        break;
                    case 2:
                        CountDown_3.text = timer.ToString();
                        break;
                }
            }
            else
            {
                //send to server inf of end
                //delete countdown, 0 money 0 points - rep - inf of zakaz
                StartCoroutine(End_Working());
            }
            PlayerPrefs.SetFloat("timer_module", timer);



        }

    }
    public IEnumerator End_Working()
    {
        WWWForm form = new WWWForm();
        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        using (UnityWebRequest www = UnityWebRequest.Post("https://doublenikmak.ru/4.0/Get_Orders.php", form))
        {

            AcceptAllCertificatesSignedWithASpecificKeyPublicKey amazonCertificateHandler = new AcceptAllCertificatesSignedWithASpecificKeyPublicKey();
            www.certificateHandler = amazonCertificateHandler;
            www.downloadHandler = new DownloadHandlerBuffer();
            yield return www.SendWebRequest();


            if (www.isNetworkError)
            {
                Debug.Log("Error");
                yield break;
            }
            else
            {
                Count = false;
                StartCoroutine(GetInf());
                yield break;
            }
        }
    }
}
