using UnityEngine;
using UnityEngine.Purchasing;


public class Game : MonoBehaviour
{
    
    private void Start()
    {
        PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable;
        PurchaseManager.OnPurchaseConsumable += PurchaseManager_OnPurchaseConsumable;
    }

    private void PurchaseManager_OnPurchaseConsumable(PurchaseEventArgs args)
    {
        Debug.Log("Your purchase: " + args.purchasedProduct.definition.id);
    }

    private void PurchaseManager_OnPurchaseNonConsumable(PurchaseEventArgs args)
    {
        Debug.Log("Your purchase: " + args.purchasedProduct.definition.id);
    }
}
