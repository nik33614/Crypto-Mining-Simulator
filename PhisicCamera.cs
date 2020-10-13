using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PhisicCamera : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera;
    public Transform Playertr;

    public GameObject Player1;
    public GameObject Camera1;
    public Transform Playertr1;

    public GameObject Player2;
    public GameObject Camera2;
    public Transform Playertr2;

    void Update()
    {
        int aaa = PlayerPrefs.GetInt("fl");

        if (aaa == 1)
        {

            var positionplayer = Player.transform.position;
            var positioncamera = Camera.transform.position;
            var yplayer = positionplayer.y;
            var ycamera = positioncamera.y;

            

            var ready = ycamera + (yplayer - ycamera);

            transform.position = Vector3.MoveTowards(transform.position, Playertr.position, Time.deltaTime);
           
        }

        if (aaa == 0)
        {
            var positionplayer = Player1.transform.position;
            var positioncamera = Camera1.transform.position;
            var yplayer = positionplayer.y;
            var ycamera = positioncamera.y;

            var ready = ycamera + (yplayer - ycamera);

            transform.position = Vector3.MoveTowards(transform.position, Playertr1.position, Time.deltaTime);
        }

        if (aaa == 2)
        {

            var positionplayer = Player2.transform.position;
            var positioncamera = Camera2.transform.position;
            var yplayer = positionplayer.y;
            var ycamera = positioncamera.y;



            var ready = ycamera + (yplayer - ycamera);

            transform.position = Vector3.MoveTowards(transform.position, Playertr2.position, Time.deltaTime);

        }
    }
}
