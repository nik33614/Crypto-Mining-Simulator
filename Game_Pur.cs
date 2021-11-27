using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Pur : MonoBehaviour
{
    
    void Start()
    {
        PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable;
        PurchaseManager.OnPurchaseConsumable += PurchaseManager_OnPurchaseConsumable;
    }
    void PurchaseManager_OnPurchaseConsumable(UnityEngine.Purchasing.PurchaseEventArgs args)
    {
        //if (args.purchasedProduct.defenition.id == )//
        Debug.Log(args.purchasedProduct.defenition.id);
    }
    void PurchaseManager_OnPurchaseNonConsumable(UnityEngine.Purchasing.PurchaseEventArgs args)
    {
        //купили товар
        //if (args.purchasedProduct.defenition.id == 0)//
        Debug.Log(args.purchasedProduct.defenition.id);
    }
}
