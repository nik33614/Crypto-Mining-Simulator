using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Get_All : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Send());
    }

   private IEnumerator Send()
    {
        WWWForm form = new WWWForm();

        form.AddField("code", PlayerPrefs.GetInt("code").ToString());

        WWW www = new WWW("http://doublenikmak.ru/GetAll.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            for(int i = 1; i < 21; i++)
            {
                PlayerPrefs.SetInt("pc" + i.ToString(), 0);
            }

            string[] sub;
            string answer = www.text;
            sub = answer.Split('_');
            int pc = Convert.ToInt32(sub[0]);
            

            PlayerPrefs.SetInt("pc" + sub[0], 1);


            for(int i = 1; i < pc; i++)
            {
                PlayerPrefs.SetInt("pc" + i.ToString(), 1);//pc
            }

            PlayerPrefs.SetInt("Graphic_Card_upgrade_PC" + pc.ToString(), Convert.ToInt32(sub[1]));//graphiccrad
        
            PlayerPrefs.SetInt("CPU_upgrade_PC" + pc.ToString(), Convert.ToInt32(sub[2]));            //cpu

            PlayerPrefs.SetInt("Mother_Board_upgrade_PC" + pc.ToString(), Convert.ToInt32(sub[3]));//motherboard

            PlayerPrefs.SetInt("Power_Supply_upgrade_PC" + pc.ToString(), Convert.ToInt32(sub[4]));//power

            PlayerPrefs.SetFloat("balance", float.Parse(sub[5]));//bitcoin

            PlayerPrefs.SetInt("balancedollars", Convert.ToInt32(sub[6]));//balance_dollars

            PlayerPrefs.SetInt("fan_timer", Convert.ToInt32(sub[7]));//fantimer

            PlayerPrefs.SetInt("fanupgrade", Convert.ToInt32(sub[8]));//fanupgrade

            for(int i = 1; i < 4; i++)
            {
                PlayerPrefs.SetInt("house" + i.ToString(), 0);
            }

            PlayerPrefs.SetInt("house" + sub[9], 1);//house
            

            for(int i = 1; i < Convert.ToInt32(sub[9]); i++)
            {
                PlayerPrefs.SetInt("house" + i.ToString(), 1);
            }

            PlayerPrefs.SetFloat("profitold", float.Parse(sub[10]));//profit_old

            PlayerPrefs.SetFloat("profitsec", float.Parse(sub[11]));//profit_sec
            
            PlayerPrefs.SetInt("debit_house", Convert.ToInt32(sub[12]));//debit_house

            PlayerPrefs.SetInt("Check_House", Convert.ToInt32(sub[13]));//check_house

            PlayerPrefs.SetInt("house_time", Convert.ToInt32(sub[14]));//house_debit_int

            PlayerPrefs.SetInt("debit_pc", Convert.ToInt32(sub[15]));//pc_debit

            PlayerPrefs.SetInt("Check_PC", Convert.ToInt32(sub[16]));//check_pc

            PlayerPrefs.SetInt("pc_time", Convert.ToInt32(sub[17]));//pc_debit_time

            PlayerPrefs.SetInt("best_score", Convert.ToInt32(sub[18]));//score

            PlayerPrefs.SetInt("salary", Convert.ToInt32(sub[19]));//salary

            PlayerPrefs.SetInt("salary_money", Convert.ToInt32(sub[20]));//salary_money

            PlayerPrefs.SetInt("cost_salary", Convert.ToInt32(sub[21]));//salary_cost

            PlayerPrefs.SetInt("time_work", Convert.ToInt32(sub[22]));//work_time

            if(sub[23] != "false"){
                PlayerPrefs.SetFloat("profit_information", float.Parse(sub[23]));
                
            }
            else{
                PlayerPrefs.SetFloat("profit_information", 0);
               
            }
            Debug.Log(PlayerPrefs.GetFloat("profit_information"));
        }
        yield break;
    }
}
