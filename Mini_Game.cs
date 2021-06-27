using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mini_Game : MonoBehaviour
{
    float timer = 1f;
    int random;
    int randomcol;
    public GameObject oneg;
    public GameObject twog;
    public GameObject threeg;
    public GameObject fourg;
    public GameObject fiveg;
    public GameObject sixg;
    public GameObject seveng;
    public GameObject eightg;
    public GameObject nineg;

    public GameObject oneb;
    public GameObject twob;
    public GameObject threeb;
    public GameObject fourb;
    public GameObject fiveb;
    public GameObject sixb;
    public GameObject sevenb;
    public GameObject eightb;
    public GameObject nineb;

    public GameObject oneo;
    public GameObject twoo;
    public GameObject threeo;
    public GameObject fouro;
    public GameObject fiveo;
    public GameObject sixo;
    public GameObject seveno;
    public GameObject eighto;
    public GameObject nineo;


    public GameObject onep;
    public GameObject twop;
    public GameObject threep;
    public GameObject fourp;
    public GameObject fivep;
    public GameObject sixp;
    public GameObject sevenp;
    public GameObject eightp;
    public GameObject ninep;


    public GameObject onepu;
    public GameObject twopu;
    public GameObject threepu;
    public GameObject fourpu;
    public GameObject fivepu;
    public GameObject sixpu;
    public GameObject sevenpu;
    public GameObject eightpu;
    public GameObject ninepu;


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



            if (random == 1)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_1", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                fiveg.SetActive(false);
                sixg.SetActive(false);
                seveng.SetActive(false);
                eightg.SetActive(false);
                nineg.SetActive(false);
                oneg.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                fourb.SetActive(false);
                fiveb.SetActive(false);
                sixb.SetActive(false);
                sevenb.SetActive(false);
                eightb.SetActive(false);
                nineb.SetActive(false);
                oneb.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                fouro.SetActive(false);
                fiveo.SetActive(false);
                sixo.SetActive(false);
                seveno.SetActive(false);
                eighto.SetActive(false);
                nineo.SetActive(false);
                oneo.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                fourp.SetActive(false);
                fivep.SetActive(false);
                sixp.SetActive(false);
                sevenp.SetActive(false);
                eightp.SetActive(false);
                ninep.SetActive(false);
                onep.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                fourpu.SetActive(false);
                fivepu.SetActive(false);
                sixpu.SetActive(false);
                sevenpu.SetActive(false);
                eightpu.SetActive(false);
                ninepu.SetActive(false);
                onepu.SetActive(true);
            }

            if (random == 2)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_2", randomcol);

                oneg.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                fiveg.SetActive(false);
                sixg.SetActive(false);
                seveng.SetActive(false);
                eightg.SetActive(false);
                nineg.SetActive(false);
                twog.SetActive(true);

                oneb.SetActive(false);
                threeb.SetActive(false);
                fourb.SetActive(false);
                fiveb.SetActive(false);
                sixb.SetActive(false);
                sevenb.SetActive(false);
                eightb.SetActive(false);
                nineb.SetActive(false);
                twob.SetActive(true);

                oneo.SetActive(false);
                threeo.SetActive(false);
                fouro.SetActive(false);
                fiveo.SetActive(false);
                sixo.SetActive(false);
                seveno.SetActive(false);
                eighto.SetActive(false);
                nineo.SetActive(false);
                twoo.SetActive(true);

                onep.SetActive(false);
                threep.SetActive(false);
                fourp.SetActive(false);
                fivep.SetActive(false);
                sixp.SetActive(false);
                sevenp.SetActive(false);
                eightp.SetActive(false);
                ninep.SetActive(false);
                twop.SetActive(true);

                onepu.SetActive(false);
                threepu.SetActive(false);
                fourpu.SetActive(false);
                fivepu.SetActive(false);
                sixpu.SetActive(false);
                sevenpu.SetActive(false);
                eightpu.SetActive(false);
                ninepu.SetActive(false);
                twopu.SetActive(true);
            }

            if (random == 3)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_3", randomcol);
                if (PlayerPrefs.GetInt("col_3") == 1)
                {
                    twog.SetActive(false);
                    oneg.SetActive(false);
                    fourg.SetActive(false);
                    fiveg.SetActive(false);
                    sixg.SetActive(false);
                    seveng.SetActive(false);
                    eightg.SetActive(false);
                    nineg.SetActive(false);
                    threeg.SetActive(true);
                }
                if (PlayerPrefs.GetInt("col_3") == 2)
                {
                    twob.SetActive(false);
                    oneb.SetActive(false);
                    fourb.SetActive(false);
                    fiveb.SetActive(false);
                    sixb.SetActive(false);
                    sevenb.SetActive(false);
                    eightb.SetActive(false);
                    nineb.SetActive(false);
                    threeb.SetActive(true);
                }
                if (PlayerPrefs.GetInt("col_3") == 3)
                {

                    twoo.SetActive(false);
                    oneo.SetActive(false);
                    fouro.SetActive(false);
                    fiveo.SetActive(false);
                    sixo.SetActive(false);
                    seveno.SetActive(false);
                    eighto.SetActive(false);
                    nineo.SetActive(false);
                    threeo.SetActive(true);
                }
                if (PlayerPrefs.GetInt("col_3") == 4)
                {
                    twop.SetActive(false);
                    onep.SetActive(false);
                    fourp.SetActive(false);
                    fivep.SetActive(false);
                    sixp.SetActive(false);
                    sevenp.SetActive(false);
                    eightp.SetActive(false);
                    ninep.SetActive(false);
                    threep.SetActive(true);
                }
                if (PlayerPrefs.GetInt("col_3") == 5)
                {
                    twopu.SetActive(false);
                    onepu.SetActive(false);
                    fourpu.SetActive(false);
                    fivepu.SetActive(false);
                    sixpu.SetActive(false);
                    sevenpu.SetActive(false);
                    eightpu.SetActive(false);
                    ninepu.SetActive(false);
                    threepu.SetActive(true);
                }
            }

            if (random == 4)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_4", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                oneg.SetActive(false);
                fiveg.SetActive(false);
                sixg.SetActive(false);
                seveng.SetActive(false);
                eightg.SetActive(false);
                nineg.SetActive(false);
                fourg.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                oneb.SetActive(false);
                fiveb.SetActive(false);
                sixb.SetActive(false);
                sevenb.SetActive(false);
                eightb.SetActive(false);
                nineb.SetActive(false);
                fourb.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                oneo.SetActive(false);
                fiveo.SetActive(false);
                sixo.SetActive(false);
                seveno.SetActive(false);
                eighto.SetActive(false);
                nineo.SetActive(false);
                fouro.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                onep.SetActive(false);
                fivep.SetActive(false);
                sixp.SetActive(false);
                sevenp.SetActive(false);
                eightp.SetActive(false);
                ninep.SetActive(false);
                fourp.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                onepu.SetActive(false);
                fivepu.SetActive(false);
                sixpu.SetActive(false);
                sevenpu.SetActive(false);
                eightpu.SetActive(false);
                ninepu.SetActive(false);
                fourpu.SetActive(true);
            }

            if (random == 5)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_5", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                oneg.SetActive(false);
                sixg.SetActive(false);
                seveng.SetActive(false);
                eightg.SetActive(false);
                nineg.SetActive(false);
                fiveg.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                oneb.SetActive(false);
                fourb.SetActive(false);
                sixb.SetActive(false);
                sevenb.SetActive(false);
                eightb.SetActive(false);
                nineb.SetActive(false);
                fiveb.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                oneo.SetActive(false);
                fouro.SetActive(false);
                sixo.SetActive(false);
                seveno.SetActive(false);
                eighto.SetActive(false);
                nineo.SetActive(false);
                fiveo.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                onep.SetActive(false);
                fourp.SetActive(false);
                sixp.SetActive(false);
                sevenp.SetActive(false);
                eightp.SetActive(false);
                ninep.SetActive(false);
                fivep.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                onepu.SetActive(false);
                fourpu.SetActive(false);
                sixpu.SetActive(false);
                sevenpu.SetActive(false);
                eightpu.SetActive(false);
                ninepu.SetActive(false);
                fivepu.SetActive(true);
            }

            if (random == 6)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_6", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                fiveg.SetActive(false);
                oneg.SetActive(false);
                seveng.SetActive(false);
                eightg.SetActive(false);
                nineg.SetActive(false);
                sixg.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                oneb.SetActive(false);
                fiveb.SetActive(false);
                fourb.SetActive(false);
                sevenb.SetActive(false);
                eightb.SetActive(false);
                nineb.SetActive(false);
                sixb.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                oneo.SetActive(false);
                fiveo.SetActive(false);
                fouro.SetActive(false);
                seveno.SetActive(false);
                eighto.SetActive(false);
                nineo.SetActive(false);
                sixo.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                onep.SetActive(false);
                fivep.SetActive(false);
                fourp.SetActive(false);
                sevenp.SetActive(false);
                eightp.SetActive(false);
                ninep.SetActive(false);
                sixp.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                onepu.SetActive(false);
                fivepu.SetActive(false);
                fourpu.SetActive(false);
                sevenpu.SetActive(false);
                eightpu.SetActive(false);
                ninepu.SetActive(false);
                sixpu.SetActive(true);
            }

            if (random == 7)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_7", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                fiveg.SetActive(false);
                sixg.SetActive(false);
                oneg.SetActive(false);
                eightg.SetActive(false);
                nineg.SetActive(false);
                seveng.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                oneb.SetActive(false);
                fiveb.SetActive(false);
                fourb.SetActive(false);
                sixb.SetActive(false);
                eightb.SetActive(false);
                nineb.SetActive(false);
                seveng.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                oneo.SetActive(false);
                fiveo.SetActive(false);
                fouro.SetActive(false);
                sixo.SetActive(false);
                eighto.SetActive(false);
                nineo.SetActive(false);
                seveno.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                onep.SetActive(false);
                fivep.SetActive(false);
                fourp.SetActive(false);
                sixp.SetActive(false);
                eightp.SetActive(false);
                ninep.SetActive(false);
                sevenp.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                onepu.SetActive(false);
                fivepu.SetActive(false);
                fourpu.SetActive(false);
                sixpu.SetActive(false);
                eightpu.SetActive(false);
                ninepu.SetActive(false);
                sevenpu.SetActive(true);
            }

            if (random == 8)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_8", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                fiveg.SetActive(false);
                sixg.SetActive(false);
                seveng.SetActive(false);
                oneg.SetActive(false);
                nineg.SetActive(false);
                eightg.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                oneb.SetActive(false);
                fiveb.SetActive(false);
                fourb.SetActive(false);
                sixb.SetActive(false);
                sevenb.SetActive(false);
                nineb.SetActive(false);
                eightb.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                oneo.SetActive(false);
                fiveo.SetActive(false);
                fouro.SetActive(false);
                sixo.SetActive(false);
                seveno.SetActive(false);
                nineo.SetActive(false);
                eighto.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                onep.SetActive(false);
                fivep.SetActive(false);
                fourp.SetActive(false);
                sixp.SetActive(false);
                sevenp.SetActive(false);
                ninep.SetActive(false);
                eightp.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                onepu.SetActive(false);
                fivepu.SetActive(false);
                fourpu.SetActive(false);
                sixpu.SetActive(false);
                sevenpu.SetActive(false);
                ninepu.SetActive(false);
                eightpu.SetActive(true);
            }

            if (random == 9)
            {
                randomcol = Random.Range(1, 6);
                PlayerPrefs.SetInt("col_9", randomcol);

                twog.SetActive(false);
                threeg.SetActive(false);
                fourg.SetActive(false);
                fiveg.SetActive(false);
                sixg.SetActive(false);
                seveng.SetActive(false);
                eightg.SetActive(false);
                oneg.SetActive(false);
                nineg.SetActive(true);

                twob.SetActive(false);
                threeb.SetActive(false);
                oneb.SetActive(false);
                fiveb.SetActive(false);
                fourb.SetActive(false);
                sixb.SetActive(false);
                eightb.SetActive(false);
                sevenb.SetActive(false);
                nineg.SetActive(true);

                twoo.SetActive(false);
                threeo.SetActive(false);
                oneo.SetActive(false);
                fiveo.SetActive(false);
                fouro.SetActive(false);
                sixo.SetActive(false);
                eighto.SetActive(false);
                seveno.SetActive(false);
                nineo.SetActive(true);

                twop.SetActive(false);
                threep.SetActive(false);
                onep.SetActive(false);
                fivep.SetActive(false);
                fourp.SetActive(false);
                sixp.SetActive(false);
                eightp.SetActive(false);
                sevenp.SetActive(false);
                ninep.SetActive(true);

                twopu.SetActive(false);
                threepu.SetActive(false);
                onepu.SetActive(false);
                fivepu.SetActive(false);
                fourpu.SetActive(false);
                sixpu.SetActive(false);
                eightpu.SetActive(false);
                sevenpu.SetActive(false);
                ninepu.SetActive(true);
            }
        }
    }
}