using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Balance : MonoBehaviour
{
    float money;
    public UnityEngine.UI.Text ScoresText;
    
    float profit;
    float profit_4;
    float time = 0.0001f;
    float time_sec = 1f;
    string a;
    int len_old;
    int len;
    string m_s;
    public int checker;
    string New_;

    void Start()
    {
        
        money = PlayerPrefs.GetFloat("balance");
        m_s = money.ToString();
    }
    void Update()
    {
        if(checker == 2)
        {
            money = PlayerPrefs.GetFloat("balance");
            m_s = money.ToString();
        }
        if (checker == 0)
        {
            time -= Time.deltaTime;
            time_sec -= Time.deltaTime;
            Plus();
        }
        else
        {
            a = Math.Round(money, 4).ToString();
            ScoresText.text = a;
        }
    }
    void Plus()
    {
        if (time <= 0)
        {
            //money = PlayerPrefs.GetFloat("balance");

            string Old_ = Math.Round(money, 4).ToString();
            //string Old_ = money.ToString();
            int old_ = Old_.Length;
            profit = PlayerPrefs.GetFloat("profitsec");
            profit_4 = profit / 10;

            //Debug.Log("a");
             double pop = Math.Round((money) + profit_4, 4);
            New_ = pop.ToString();
            money += profit_4;
            int new_ = New_.Length;

            if (new_ < old_)
            {
                New_ = New_ + "0";
                 new_ = New_.Length;

                if (new_ < old_)
                {
                    New_ = New_ + "0";
                     new_ = New_.Length;

                    if (new_ < old_)
                    {
                        New_ = New_ + "0";
                         new_ = New_.Length;

                        if (new_ < old_)
                        {
                            New_ = New_ + "0";
                            

                        }
                        
                    }
                   

                }
               

            }
            




          ///  m_s = money.ToString();

            //Debug.Log(m_s);
            ///string len_ = m_s.Substring(0, m_s.IndexOf(","));
            //Debug.Log(len_);
            ///int len_1 = len_.Length + 1;//колличество чисел до запятой
           /// a = Math.Round(money, 4).ToString();
           /// len = a.Length;//колличество всех чисел
          ///  len -= len_1;

            
            ///profit = PlayerPrefs.GetFloat("profitsec");
            ///profit_4 = profit / 10;
             //len_old = len_;

             ///money += profit_4;
             //a = Math.Round(money, 4).ToString();
             //len = a.Length;
            //Debug.Log(len_old);
            //Debug.Log("1" + len);
          ///  if(len < 4)
          ///  {
            ///    a = a + "0";
           ///     len = a.Length;
           ///     len -= len_1;
                //Debug.Log("2" + len);
            ///    if (len < 4)
           ///     {
           ///         a = a + "0";
            ///        len = a.Length;
           ///         len -= len_1;
                    //  Debug.Log("3" + len);
            ///        if (len < 4)
            ///        {
            // /           a = a + "0";
            ///            len = a.Length;
             ///           len -= len_1;
                        //    Debug.Log("4" + len);
              ///          if (len < 4)
              ///          {
               ///             a = a + "0";

              ///          }
             ///       }
                   
            ///    }
                
          ///  }
            ///m_s = a;
            New_ = New_ + " ₿";
            ScoresText.text = New_;
            time = 0.1f;
        }
        if (time_sec <= 0)
        {
            money = PlayerPrefs.GetFloat("balance");
             New_ = Math.Round(money, 4).ToString();
            New_ = New_ + " ₿";
           ScoresText.text = New_;
            time_sec = 10f;
        }
    }
}
