using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flightt : MonoBehaviour
{
    public GameObject player;

    public float force;

    private new Rigidbody2D rigidbody;

    public int b;

    int time;

    void Awake()
    {

        rigidbody = GetComponent<Rigidbody2D>();

    }

    public void Fly()
    {
        if (b == 1)
        {
            rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);

            PlayerPrefs.SetInt("cheks", 1);
        }
        if (b == 2)
        {
            rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);

            PlayerPrefs.SetInt("cheks", 2);
        }
    }

    // сделать поворот при разных нажимах
    // это два скрипта с разными поворотами


}
