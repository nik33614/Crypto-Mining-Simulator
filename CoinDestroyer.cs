using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyer : MonoBehaviour
{

    public float timer;
    int money;
    public int a;

    void Update()
    {

        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {

        if (timer <= 0)
        {
            money = PlayerPrefs.GetInt("money");

            money += a;

            PlayerPrefs.SetInt("money", money);

            Destroy(gameObject);

        }

    }


}
