using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Images : MonoBehaviour
{
    /*
    public GameObject Panel_1;

    public GameObject Text_1;
    public GameObject Text_2;
    public GameObject Text_3;

    public Text Text_4;

    public GameObject Help_1;
    public GameObject Help_2;
    public GameObject Help_3;
    public GameObject Help_4;
    public GameObject Letsgo;

    public GameObject Help_Me;

    public GameObject Up;

    float timer = 12f;
    bool Start_Time = true;
    public int Main_Help;

    void Start()
    {
        StartCoroutine(Code());
        PlayerPrefs.DeleteAll();
        Panel_1.SetActive(true);
        Text_1.SetActive(true);
        PlayerPrefs.SetInt("dollars", 1000);
        
    }

    void Update()
    {
       
        if (Start_Time == true)
        {
            timer -= Time.deltaTime;
            if(timer<=0)
            {
                if (Main_Help == 0)// internet starts
                {
                    Start_Time = false;
                    Help_1.GetComponent<Animation>().Play("Help_Internet");
                   
                }
                if (Main_Help == 2)//shop starts
                {
                    Help_2.GetComponent<Animation>().Play("Shop_Help");
                }

                if (Main_Help == 1)//panel moves down 
                {
                    timer = 12f;
                    Text_2.SetActive(true);
                    Text_1.SetActive(false);
                    Help_1.GetComponent<Animation>().Stop("Help_Internet");
                    Panel_1.GetComponent<Animation>().Play("Panel_1");
                    Main_Help = 2;
                }
                
                if (Main_Help == 3)// panel goes up 
                {   
                    Text_3.SetActive(true);
                    Text_2.SetActive(false);
                    Up.SetActive(true);
                    Start_Time = false;
                    Help_1.GetComponent<Animation>().Stop("Shop_Help");
                    Panel_1.GetComponent<Animation>().Play("Panel_2");
                }
                if(Main_Help == 6)// help me starets blinding
                {
                    Help_Me.GetComponent<Animation>().Play("Help_Me");
                    Start_Time = false;
                    
                }
                if (Main_Help == 4)//panel sets off
                {
                    Panel_1.SetActive(false);
                    Text_3.SetActive(false);
                    Text_4.gameObject.SetActive(false);
                    Up.SetActive(false);
                    timer = 0.5f;
                    Main_Help = 6;
                    Help_Me.SetActive(true); 
                }
                if (Main_Help == 5)// help me turns off
                {
                    Up.SetActive(true);
                    Text_4.gameObject.SetActive(true);
                    
                    string to_print = "Now buy all parts: Motherboard, power, cooler system, cpu and graphic card";
                    if (PlayerPrefs.GetInt("Motherboard") != 0)
                    {
                        to_print = to_print.Replace(" Motherboard,", "");
                    }
                    if (PlayerPrefs.GetInt("Consumption") != 0)
                    {
                        to_print = to_print.Replace(" power,", "");
                    }
                    if (PlayerPrefs.GetInt("Graphic") != 0)
                    {
                        to_print = to_print.Replace(" and graphic card", "");
                    }
                    if (PlayerPrefs.GetInt("Cpu") != 0)
                    {
                        to_print = to_print.Replace(" cpu", "");
                    }
                    
                    if (PlayerPrefs.GetInt("Cooler_Time") != 0)
                    {
                        to_print = to_print.Replace(" cooler system,", "");
                    }
                    StartCoroutine(c_Output(to_print, 0.09f, Text_4));
                    
                    Help_Me.SetActive(false);
                   
                    Start_Time = false;
                }
                if (Main_Help == 8)//performance starts blinding
                {
                    Help_3.GetComponent<Animation>().Play("Performance_Help");
                    Start_Time = false;
                }
               
                if (Main_Help == 7)//when finished turns on next panel
                {
                    Panel_1.SetActive(true);
                    Text_4.gameObject.SetActive(true);
                    Help_Me.SetActive(false);
                    StartCoroutine(c_Output("Open performance to turn on computer", 0.09f, Text_4));
                    timer = 10f;
                    Main_Help = 8;
                    Start_Time = true;
                }
                if (Main_Help == 10)//help cooling starts blindong
                {
                    Help_4.SetActive(true);
                    Start_Time = false;

                }

                if (Main_Help == 9)//panel goes down 
                {
                    Help_3.GetComponent<Animation>().Stop("Performance_Help");
                    Panel_1.GetComponent<Animation>().Play("Panel_3");
                    StartCoroutine(c_Output("Tap on the cooling system", 0.09f, Text_4));//анимация передвиэения в дркгое место
                    Start_Time = true;
                    timer = 2f;
                    Main_Help = 10;
                }
                
                if (Main_Help == 11)// next text 
                {
                    
                    Help_4.GetComponent<Animation>().Stop("Help_Cooling");
                    Letsgo.SetActive(true);
                    StartCoroutine(c_Output("Now you have to log in or sign up", 0.09f, Text_4));
                    Start_Time = false;
                }
            }
        }
        
        if (PlayerPrefs.GetInt("Motherboard") != 0 && PlayerPrefs.GetInt("Consumption") != 0 && PlayerPrefs.GetInt("Graphic") != 0 && PlayerPrefs.GetInt("Cpu") != 0 && PlayerPrefs.GetInt("Cooler_Time") != 0 && Main_Help < 7)
        {
             Start_Time = true;

             Main_Help = 7;
         }
            //just change scene;
    }
    public void Set_Timer_False(int Help)
    {
       
        Start_Time = true;
        timer = 0;
       
        Main_Help = Help;
     

    }
    public void Okay()
    {
        Main_Help = 4;
        timer = 0.5f;
        Panel_1.GetComponent<Animation>().Play("Close");
        Start_Time = true;

    }
    public void Help_me()
    {
        Panel_1.SetActive(true);
        
        Start_Time = true;
        Main_Help = 5;
        
    }
    IEnumerator c_Output(string str, float delay, Text txt)
    {
        txt.text = "";
        foreach (var sym in str)
        {


            txt.text += sym;

            yield return new WaitForSeconds(delay);
        }
    }
    public IEnumerator Code()
    {
        WWWForm form = new WWWForm();
        int code = Random.Range(1000000, 9999999);
        form.AddField("code", code);
        WWW www = new WWW("https://doublenikmak.ru/4.0/Code.php", form);
        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            if (www.text == "1")
            {
                StartCoroutine(Code());
                yield break;
            }
            else
            {
                PlayerPrefs.SetInt("code", code);
                Debug.Log(code);
                yield break;
            }
        }
    }
    */
}
