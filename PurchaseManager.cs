using System;
using UnityEngine;
using UnityEngine.Purchasing;
using System.Collections;
using System.Collections.Generic;

public class PurchaseManager : MonoBehaviour, IStoreListener
{
    private static IStoreController m_StoreController;
    private static IExtensionProvider m_StoreExtensionProvider;
    private int currentProductIndex;

    int code;
    int balance;
    float bit;

    public string[] NC_PRODUCTS;
  
    public string[] C_PRODUCTS;

    
    public static event OnSuccessConsumable OnPurchaseConsumable;
    
    public static event OnSuccessNonConsumable OnPurchaseNonConsumable;
   
    public static event OnFailedPurchase PurchaseFailed;

    private void Awake()
    {
        InitializePurchasing();
    }
   
    public static bool CheckBuyState(string id)
    {
        Product product = m_StoreController.products.WithID(id);
        if (product.hasReceipt) { return true; }
        else { return false; }
    }

    public void InitializePurchasing()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
        foreach (string s in C_PRODUCTS) builder.AddProduct(s, ProductType.Consumable);
        foreach (string s in NC_PRODUCTS) builder.AddProduct(s, ProductType.NonConsumable);
        UnityPurchasing.Initialize(this, builder);
    }

    private bool IsInitialized()
    {
        return m_StoreController != null && m_StoreExtensionProvider != null;
    }

    public void BuyConsumable(int index)
    {
        currentProductIndex = index;
        BuyProductID(C_PRODUCTS[index]);
    }

    public void BuyNonConsumable(int index)
    {
        currentProductIndex = index;
        BuyProductID(NC_PRODUCTS[index]);
    }

    void BuyProductID(string productId)
    {
        if (IsInitialized())
        {
            Product product = m_StoreController.products.WithID(productId);

            if (product != null && product.availableToPurchase)
            {
                Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
                m_StoreController.InitiatePurchase(product);
            }
            else
            {
                Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
                OnPurchaseFailed(product, PurchaseFailureReason.ProductUnavailable);
            }
        }
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        Debug.Log("OnInitialized: PASS");

        m_StoreController = controller;
        m_StoreExtensionProvider = extensions;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
    }

    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
    {
        if (C_PRODUCTS.Length > 0 && String.Equals(args.purchasedProduct.definition.id, C_PRODUCTS[currentProductIndex], StringComparison.Ordinal))
            OnSuccessC(args);
        else if (NC_PRODUCTS.Length > 0 && String.Equals(args.purchasedProduct.definition.id, NC_PRODUCTS[currentProductIndex], StringComparison.Ordinal))
            OnSuccessNC(args);
        else Debug.Log(string.Format("ProcessPurchase: FAIL. Unrecognized product: '{0}'", args.purchasedProduct.definition.id));
        return PurchaseProcessingResult.Complete;
    }

    public delegate void OnSuccessConsumable(PurchaseEventArgs args);
    protected virtual void OnSuccessC(PurchaseEventArgs args)
    {
        if (OnPurchaseConsumable != null) OnPurchaseConsumable(args);
        Debug.Log(C_PRODUCTS[currentProductIndex] + " Buyed!");
        
        if (C_PRODUCTS[currentProductIndex]  == "dollars_10000")
        {
            PlayerPrefs.SetInt("balancedollars", PlayerPrefs.GetInt("balancedollars") + 10000);
        }
        if (C_PRODUCTS[currentProductIndex] == "dollars_50000")
        {
            PlayerPrefs.SetInt("balancedollars", PlayerPrefs.GetInt("balancedollars") + 50000);
        }
        if (C_PRODUCTS[currentProductIndex] == "dollars_300000")
        {
            PlayerPrefs.SetInt("balancedollars", PlayerPrefs.GetInt("balancedollars") + 300000);
        }

        StartCoroutine(Send());
        StartCoroutine(Purchase_());
        

    }
    public delegate void OnSuccessNonConsumable(PurchaseEventArgs args);
    protected virtual void OnSuccessNC(PurchaseEventArgs args)
    {
        if (OnPurchaseNonConsumable != null) OnPurchaseNonConsumable(args);
        Debug.Log(NC_PRODUCTS[currentProductIndex] + " Buyed!");
        if (NC_PRODUCTS[currentProductIndex] == "stop_ads")
        {
            PlayerPrefs.SetInt("stop_ads", 1);
        }
        StartCoroutine(Send_Ad());
        StartCoroutine(Purchase_());
        //Debug.Log(args.purchasedProduct.defenition.id);
    }
    public delegate void OnFailedPurchase(Product product, PurchaseFailureReason failureReason);
    protected virtual void OnFailedP(Product product, PurchaseFailureReason failureReason)
    {
        if (PurchaseFailed != null) PurchaseFailed(product, failureReason);
        Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", product.definition.storeSpecificId, failureReason));
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        OnFailedP(product, failureReason);
    }

    private IEnumerator Send()
    {

        code = PlayerPrefs.GetInt("code");
        balance = PlayerPrefs.GetInt("balancedollars");
        bit = PlayerPrefs.GetFloat("balance");



        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("balance", balance);
        form.AddField("bitcoin", Math.Round(bit, 4).ToString());
        WWW www = new WWW("http://doublenikmak.ru/Get_Money_Bit.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            yield break;
        }
    }

    private IEnumerator Send_Ad()
    {

        code = PlayerPrefs.GetInt("code");
        
        WWWForm form = new WWWForm();
        form.AddField("code", code);
        form.AddField("ad", "1");

        WWW www = new WWW("http://doublenikmak.ru/Send_Ads.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Произошла ошибка: " + www.error);
            yield break;
        }
        else
        {
            yield break;
        }
    }

private IEnumerator Purchase_()
    {

        code = PlayerPrefs.GetInt("code");
        
        WWWForm form = new WWWForm();
        form.AddField("code", code);

        WWW www = new WWW("http://doublenikmak.ru/Purchase.php", form);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("Error: " + www.error);
            yield break;
        }
        else
        {
            yield break;
        }
    }
}