using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class Purchase : MonoBehaviour
{
    

    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == "Money_100")
        {
            int a = PlayerPrefs.GetInt("money");
            a = a + 100;
            PlayerPrefs.SetInt("money", a);
        }
        else if (product.definition.id == "Money_500")
        {
            int b = PlayerPrefs.GetInt("money");
            b = b + 500;
            PlayerPrefs.SetInt("money", b);

        }
        else if (product.definition.id == "Money_1000")
        {
            int c = PlayerPrefs.GetInt("money");
            c = c + 1000;
            PlayerPrefs.SetInt("money", c);

        }
        else if (product.definition.id == "NoAds")
        {
            PlayerPrefs.SetInt("ads",1);
            

        }
    }
}
