using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnActive : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    public void False()
    {
        Object.SetActive(false);
    }
    public void True()
    {
        Object.SetActive(true);
    }
}
