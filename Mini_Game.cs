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
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                one.SetActive(true);
            }

            if (random == 2)
            {
                one.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                two.SetActive(true);
            }

            if (random == 3)
            {
                two.SetActive(false);
                one.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                three.SetActive(true);
            }

            if (random == 4)
            {
                two.SetActive(false);
                three.SetActive(false);
                one.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                four.SetActive(true);
            }

            if (random == 5)
            {
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                one.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                five.SetActive(true);
            }

            if (random == 6)
            {
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                one.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                six.SetActive(true);
            }

            if (random == 7)
            {
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                one.SetActive(false);
                eight.SetActive(false);
                nine.SetActive(false);
                seven.SetActive(true);
            }

            if (random == 8)
            {
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                one.SetActive(false);
                nine.SetActive(false);
                eight.SetActive(true);
            }

            if (random == 9)
            {
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);
                six.SetActive(false);
                seven.SetActive(false);
                eight.SetActive(false);
                one.SetActive(false);
                nine.SetActive(true);
            }
        }
    }
}
