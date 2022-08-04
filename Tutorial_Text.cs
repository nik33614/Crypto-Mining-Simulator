using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Text : MonoBehaviour
{
    public Text txt;
    public string text_to_print;
    void Start()
    {
        StartCoroutine(c_Output(text_to_print, 0.09f));
    }

    IEnumerator c_Output(string str, float delay)
    {
        foreach (var sym in str)
        {
            

            txt.text += sym;

            yield return new WaitForSeconds(delay);
        }
    }
}
