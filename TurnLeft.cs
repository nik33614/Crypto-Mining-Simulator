using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeft : MonoBehaviour
{
    public void Left()
    {
        transform.Rotate(new Vector3(0, 0, 80)* Time.deltaTime);

    }
}
