using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMovementScript : MonoBehaviour
{
    private Rigidbody mRigidbody;

    private float movementForce = 10f;


    private void Awake()
    {
        mRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            mRigidbody.AddForce(movementForce * transform.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            mRigidbody.AddForce(movementForce * -transform.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            mRigidbody.AddForce(movementForce * -transform.right);
        }
        if (Input.GetKey(KeyCode.D))
        {
            mRigidbody.AddForce(movementForce * transform.right);
        }
    }
}
