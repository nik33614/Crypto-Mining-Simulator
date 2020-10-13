using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBut : MonoBehaviour
{
    
    public string a;
    public int b;
    public GameObject c;
    

    

    public void Collect()
    {
        
        PlayerPrefs.SetInt(a, 2);
        int z = PlayerPrefs.GetInt("money");
        z += b;
        PlayerPrefs.SetInt("money",z);

        
        c.SetActive(false);
    }
}
