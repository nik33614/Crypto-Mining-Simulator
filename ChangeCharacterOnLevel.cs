using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacterOnLevel : MonoBehaviour
{

    public GameObject char1;
    public GameObject char2;
    public GameObject char3;

    void Start()
    {
        int aaa = PlayerPrefs.GetInt("fl");
       

        if (aaa == 1)
        {
            char1.SetActive(false);
            char2.SetActive(true);
            char3.SetActive(false);

        }

        if (aaa == 0)
        {
            char1.SetActive(true);
            char2.SetActive(false);
            char3.SetActive(false);

        }

        if (aaa == 2)
        {
            char1.SetActive(false);
            char2.SetActive(false);
            char3.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
