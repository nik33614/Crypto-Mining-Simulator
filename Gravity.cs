using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    float gravity;
    int character;
    int characterbuy;

    void Start()
    {
        int aaa = PlayerPrefs.GetInt("fl");
        if (aaa == 0)
        {
            
            int z  = PlayerPrefs.GetInt("gravityupgrade");
            gravity = z * 0.01f + 0.6f;
        }

        if (aaa == 1)
        {
            
            int z = PlayerPrefs.GetInt("gravityupgrade1");
            gravity = z * 0.01f + 0.6f;
        }

        if (aaa == 2)
        {

            int z = PlayerPrefs.GetInt("gravityupgrade2");
            gravity = z * 0.01f + 0.6f;
        }
        Debug.Log(gravity);
        if(gravity <= 0.6f)
        {
            gravity = 0.6f;
        }
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}
