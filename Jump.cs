using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject player;
    private new Rigidbody2D rigidbody;
    float HighJump;
    float SpeedJump;
    float run;
    void Start()
    {

        int aaa = PlayerPrefs.GetInt("fl");
        if (aaa == 0)
        {
            run = PlayerPrefs.GetFloat("run");
            HighJump = PlayerPrefs.GetFloat("jump");
        }

        if (aaa == 1)
        {
            run = PlayerPrefs.GetFloat("run1");
            HighJump = PlayerPrefs.GetFloat("jump1");
        }

        if (aaa == 2)
        {
            run = PlayerPrefs.GetFloat("run2");
            HighJump = PlayerPrefs.GetFloat("jump2");
        }
    
        
        SpeedJump = run;

        if(HighJump == 0)
        {
            PlayerPrefs.SetFloat("HighJump", 4);
            HighJump = 4;
        }
        

        

        SpeedJump += 0.03f;
    }

    void Awake()
    {

        rigidbody = GetComponent<Rigidbody2D>();

    }
    void OnTriggerEnter2D(Collider2D col)
    {
       if (col.tag == "Grown")
       {
            JumpOnLevel();
            
        }
    }
    void JumpOnLevel()
    {
        rigidbody.AddForce(Vector2.up * (HighJump - rigidbody.velocity.y), ForceMode2D.Impulse);
        //rigidbody.AddForce(Vector2.right * (SpeedJump - rigidbody.velocity.x), ForceMode2D.Impulse);
    }
}
