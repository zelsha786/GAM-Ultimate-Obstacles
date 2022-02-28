using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 V3force;


    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity+=V3force;
    }
}
