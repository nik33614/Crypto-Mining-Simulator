using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnButton : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    Vector3 m_EulerAngleVelocity;
    void Start()
    {
        m_EulerAngleVelocity = new Vector3(0, 100, 0);

        m_Rigidbody = GetComponent<Rigidbody>();
    }
    public void Right()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);

    }

    
}
