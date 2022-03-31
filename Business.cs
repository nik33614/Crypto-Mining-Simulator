using System.Collections;//not ready!
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Business : MonoBehaviour
{
    //Hello there! Started writing a script on 07.08.2021 by nik33614
    /// <summary>
    /// PHP:
    /// 1. Skript for getting capital
    /// 2. Skript for getting debts
    /// 3. Skript for getting salary
    /// 4. Skript for getting people
    /// 5. Skript for getting status
    /// 6. Skript for getting name
    /// 7. Skript for getting photo
    /// 8. Skript for getting pc_upgrade
    /// 9. Skript for getting office
    /// </summary>

    int status;
    int code;
    string company_name;
    int check_image;
    float timer = 1f;
    int salary;
    int worker;

    public int scene_1;
    public int scene_2;
    public int check_scene;
    public InputField field;
    public GameObject Logo1;
    public GameObject Logo2;
    public GameObject Logo3;
    public GameObject Logo4;
    public GameObject Logo5;
    public Text text;
    public Text People;
    public Text Profit;
    public Text Capital;
    public Text One;
    public Text Two;
    public Text Three;
    public Text Four;
    public Text Five;
    public Text Six;
    public Text Seven;
    public Text Eight;
    public Text Nine;
    public Text Ten;
    public int people;
    public int scene_people1;
    public int scene_people2;
    public int scene_people3;
    public int scene_people4;
    public int scene_people5;
    public int scene_people6;
    public int scene_people7;
    public int scene_people8;
    public int scene_people9;
    public int scene_people10;


    /// <summary>
    /// îòäåëüíà òàáëèöà ñ áèçíåñàìè. â êàæäîì áèçíåñå ìàêñèìóì 10 ÷åëîâåê 
    /// ïðîôèò íà÷è`
    /// êàæäûé äåíü/÷àñ êàê è íà ðàáîòå íà÷èñëÿåòñÿ çàðïëàòà, êîòîðàÿ âû÷èòàåòñÿ èç êàïèòàëà.åñëè äèðåêòîð íå çàõîäèò â èãðó þîëåå 3 äíåé, òî ïðîôèò ïåðåñòàåò äîáàâëÿòüñÿ è áèçíåñ óõîäèò â ìèíóñ
    /// òàêæå ïðîèñõîäèò âûâîä
    /// 
    /// ìåíþ â êîòîðîì âñå èãðîêè. Äëÿ êàæäîãî äèðåêòîð ïðîêà÷èâàåò êîìï. Èãðîê äîëæåí çàõîäèòü â èãðó è èãðàòü â ìèíèèãðó, ÷òîáû ïîëó÷àòü ýêñòðà çàðîáîòîê. Êàê è îáû÷íûé êîìï ñèñåòìà îõëàæäåíè÷ÿ. ïî óìîë÷àíèþ ó èãðîêà ìèíèìàëüíûé êîìï.
    /// Òàêèå æå êîìïû êàê è îáû÷íûå, òîëüêî öåíû íàìíîãî âûøåý.
    /// </summary>

    void Start()
    {
        code = PlayerPrefs.GetInt("code");

        if (check_scene == 0)
        {
            status = PlayerPrefs.GetInt("status");
            ///status 0 - haven't got anything
            ///status 1 - have got own buisness;
            ///status 2 - he is a worker on it
            if (status == 1)
            {
                SceneManager.LoadScene(scene_1);
            }
            if (status == 2)
            {
                SceneManager.LoadScene(scene_2);
            }
        }
        if(check_scene == 4)
        {
            StartCoroutine(First());
            StartCoroutine(Second());
            StartCoroutine(Third());
            StartCoroutine(Forth());
            StartCoroutine(Fifth());
            StartCoroutine(Sixth());
            StartCoroutine(Seventh());
            StartCoroutine(Eighth());
            StartCoroutine(Nineth());
            StartCoroutine(Tenth());
            One.text = PlayerPrefs.GetString("first");
            Two.text = PlayerPrefs.GetString("second");
            Three.text = PlayerPrefs.GetString("third");
            Four.text = PlayerPrefs.GetString("forth");
            Five.text = PlayerPrefs.GetString("fifth");
            Six.text = PlayerPrefs.GetString("sixth");
            Seven.text = PlayerPrefs.GetString("seventh");
            Eight.text = PlayerPrefs.GetString("eighth");
            Nine.text = PlayerPrefs.GetString("nineth");
            Ten.text = PlayerPrefs.GetString("tenth");
        }
        if (check_scene == 3)
        {
            check_image = 1;
            Logo1.SetActive(true);
        }
        if(check_scene == 5)
        {
            worker = PlayerPrefs.GetInt("people_inf");
            StartCoroutine(Profit_worker());
            StartCoroutine(Salary_worker());
            StartCoroutine(Online_worker());
            StartCoroutine(Pc_worker());

        }

    }


    void Update()
    {
        if(check_scene == 1)
        {
            People.text = PlayerPrefs.GetInt("people").ToString();
            Profit.text = PlayerPrefs.GetInt("profit_business").ToString();
            Capital.text = PlayerPrefs.GetInt("capital").ToString();
            timer -= Time.deltaTime;
            Plus();
        }

        if (check_scene == 3)
        {
            if (check_image == 1)
            {
                Logo1.SetActive(true);
                Logo2.SetActive(false);
                Logo3.SetActive(false);
                Logo4.SetActive(false);
                Logo5.SetActive(false);
                PlayerPrefs.SetInt("logo", 1);
            }
            if (check_image == 2)
            {
                Logo1.SetActive(false);
                Logo2.SetActive(true);
                Logo3.SetActive(false);
                Logo4.SetActive(false);
                Logo5.SetActive(false);
                PlayerPrefs.SetInt("logo", 2);
            }
            if (check_image == 3)
            {
                Logo1.SetActive(false);
                Logo2.SetActive(false);
                Logo3.SetActive(true);
                Logo4.SetActive(false);
                Logo5.SetActive(false);
                PlayerPrefs.SetInt("logo", 3);
            }
            if (check_image == 4)
            {
                Logo1.SetActive(false);
                Logo2.SetActive(false);
                Logo3.SetActive(false);
                Logo4.SetActive(true);
                Logo5.SetActive(false);
                PlayerPrefs.SetInt("logo", 4);
            }
            if (check_image == 5)
            {
                Logo1.SetActive(false);
                Logo2.SetActive(false);
                Logo3.SetActive(false);
                Logo4.SetActive(false);
                Logo5.SetActive(true);
                PlayerPrefs.SetInt("logo", 5);
            }
        }
    }

    public void Company_Name()
    {
        company_name = field.text;
        PlayerPrefs.SetString("company_name", company_name);
    }
    public void Select_Image_Right()
    {
        if (check_image < 5)
        {
            check_image += 1;
        }
        else
        {
            check_image = 1;
        }

    }
    public void Select_Image_Left()
    {
        if (check_image > 1)
        {
            check_image -= 1;
        }
        else
        {
            check_image = 5;
        }
    }
    public void Next()
    {
        StartCoroutine(Checks());
    }
    public void Plus()
    {
        if (timer <= 0)
        {
            StartCoroutine(Profit_get());
            StartCoroutine(People_get());
            StartCoroutine(Capital_get());
            timer = 1f;

            int time_old = PlayerPrefs.GetInt("time_business");
            double time_double_new = DateTime.Now.Subtract(new DateTime(2021, 3, 4)).TotalSeconds;
            int time_new = Convert.ToInt32(Math.Round(time_double_new, 0));

            int alltime = time_new - time_old;
            
            if (alltime <= 86400)
            {
                if (alltime >= 3600)
                {
                    float minutes = (alltime / 60) / 60;
                    int minutes_time = Convert.ToInt32(Math.Round(minutes, 0));
                    float salary_time_float = PlayerPrefs.GetInt("profit_business") / 24;
                    int salary_time = Convert.ToInt32(Math.Round(salary_time_float, 0));
                    int salary_total = minutes_time * salary_time;
                    int salary_total_y = PlayerPrefs.GetInt("capital");
                    PlayerPrefs.SetInt("capital", salary_total_y + salary_total);
                    PlayerPrefs.SetInt("time_business", time_new);
                }
            }
            else
            {
                if (alltime <= 259200)
                {
                    float big_time = alltime / 86400;
                    int big_time_int = Convert.ToInt32(Math.Round(big_time, 0));
                    int salary_total = big_time_int * PlayerPrefs.GetInt("profit_business");
                    int salary_total_y = PlayerPrefs.GetInt("capital");
                    PlayerPrefs.SetInt("capital", salary_total_y + salary_total);
                    PlayerPrefs.SetInt("time_business", time_new);
                }
                else
                {
                    alltime = 259200;
                    float big_time = alltime / 86400;
                    int big_time_int = Convert.ToInt32(Math.Round(big_time, 0));
                    int salary_total = big_time_int * PlayerPrefs.GetInt("profit_business");
                    int salary_total_y = PlayerPrefs.GetInt("capital");
                    PlayerPrefs.SetInt("capital", salary_total_y + salary_total);
                    PlayerPrefs.SetInt("time_business", time_new);
                }
            }
        }
    }

    private IEnumerator Checks()
    {

        string name = PlayerPrefs.GetString("company_name");
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        WWW www = new WWW("http://doublenikmak.ru/Leaderboard/Leaderboard.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {
            string answer = www.text;
            if (answer == "True")
            {
                text.text = "This name is already exsisted";

            }
            else
            {
                StartCoroutine(Send());
            }
        }
    }
    private IEnumerator Send()
    {
        code = PlayerPrefs.GetInt("code");
        int logo = PlayerPrefs.GetInt("logo");
        string name = PlayerPrefs.GetString("company_name");
        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("logo", logo);
        form.AddField("company_name", name);
        WWW www = new WWW("http://doublenikmak.ru/Get_House_balance.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {
            SceneManager.LoadScene(scene_1);
        }

    }


    private IEnumerator Profit_get()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);
        ///
        ///åù¸ ÷òî òî

        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
    private IEnumerator People_get()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
    private IEnumerator Capital_get()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        { 

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator First()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Second()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Third()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Forth()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Fifth()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Sixth()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Seventh()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Eighth()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Nineth()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }

    private IEnumerator Tenth()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
    public void Scene_People()
    {
        if(people == 1)
        {
            PlayerPrefs.SetInt("people_inf", 1);
            SceneManager.LoadScene(scene_people1);
        }
        if (people == 2)
        {
            PlayerPrefs.SetInt("people_inf", 2);
            SceneManager.LoadScene(scene_people2);
        }
        if (people == 3)
        {
            PlayerPrefs.SetInt("people_inf", 3);
            SceneManager.LoadScene(scene_people3);
        }
        if (people == 4)
        {
            PlayerPrefs.SetInt("people_inf", 4);
            SceneManager.LoadScene(scene_people4);
        }
        if (people == 5)
        {
            PlayerPrefs.SetInt("people_inf", 5);
            SceneManager.LoadScene(scene_people5);
        }
        if (people == 6)
        {
            PlayerPrefs.SetInt("people_inf", 6);
            SceneManager.LoadScene(scene_people6);
        }
        if (people == 7)
        {
            PlayerPrefs.SetInt("people_inf", 7);
            SceneManager.LoadScene(scene_people7);
        }
        if (people == 8)
        {
            PlayerPrefs.SetInt("people_inf", 8);
            SceneManager.LoadScene(scene_people8);
        }
        if (people == 9)
        {
            PlayerPrefs.SetInt("people_inf", 9);
            SceneManager.LoadScene(scene_people9);
        }
        if (people == 10)
        {
            PlayerPrefs.SetInt("people_inf", 10);
            SceneManager.LoadScene(scene_people10);
        }
    }

    private IEnumerator Profit_worker()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
    private IEnumerator Online_worker()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
    private IEnumerator Salary_worker()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
    private IEnumerator Pc_worker()
    {
        WWWForm form = new WWWForm();
        code = PlayerPrefs.GetInt("code");
        form.AddField("code", code);


        WWW www = new WWW("http://doublenikmak.ru/Dollars.php", form);//

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Ïðîèçîøëà îøèáêà: " + www.error);
            yield break;
        }
        else
        {

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(www.text));
        }
    }
}
