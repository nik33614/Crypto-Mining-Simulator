using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using System.Diagnostics;

public class PurchaseSourse : MonoBehaviour
{
    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == "Money_100")
        {
            
        }
        else if (product.definition.id == "Money_500")
        {

        }
        else if (product.definition.id == "Money_1000")
        {

        }
        else if (product.definition.id == "NoAds")
        {

        }
    }
}
