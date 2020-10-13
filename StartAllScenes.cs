using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAllScenes : MonoBehaviour
{

    public float timer;

    public GameObject first;
    public GameObject second;
    public GameObject third;
    public GameObject forth;
    public GameObject fifth;
    public GameObject sixth;
    public GameObject seventh;
    public GameObject eightth;
    public GameObject nineth;
    public GameObject tenth;
    public GameObject eleventh;
    public GameObject twelveth;

    void Start()
    {
        
        first.SetActive(false);
        second.SetActive(false);
        third.SetActive(false);
        forth.SetActive(false);
        fifth.SetActive(false);
        sixth.SetActive(false);
        seventh.SetActive(false);
        eightth.SetActive(false);
        nineth.SetActive(false);
        tenth.SetActive(false);
        eleventh.SetActive(false);
        twelveth.SetActive(false);

    }

    void Update()
    {

        timer -= Time.deltaTime;

        Plus();

    }

    void Plus()
    {

        if (timer <= 0)
        {

            first.SetActive(true);
            second.SetActive(true);
            third.SetActive(true);
            forth.SetActive(true);
            fifth.SetActive(true);
            sixth.SetActive(true);
            seventh.SetActive(true);
            eightth.SetActive(true);
            nineth.SetActive(true);
            tenth.SetActive(true);
            eleventh.SetActive(true);
            twelveth.SetActive(true);


        }

    }
}
