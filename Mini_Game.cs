using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Game : MonoBehaviour
{
    float timer = 1f;
    int random;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;


    void Start()
    {

    }
    

    void Update()
    {
        timer -= Time.deltaTime;

        Plus();
    }

    public void Plus()
    {
        if (timer <= 0)
        {
            timer = 1f;
            random = Random.Range(1, 10);
            
            if(random == 1)
            {
                
                one.SetActive(true);
            }

            if (random == 2)
            {

                two.SetActive(true);
            }

            if (random == 3)
            {

                three.SetActive(true);
            }

            if (random == 4)
            {

                four.SetActive(true);
            }

            if (random == 5)
            {

                five.SetActive(true);
            }

            if (random == 6)
            {

                six.SetActive(true);
            }

            if (random == 7)
            {

                seven.SetActive(true);
            }

            if (random == 8)
            {

                eight.SetActive(true);
            }

            if (random == 9)
            {

                nine.SetActive(true);
            }
        }
    }
}
