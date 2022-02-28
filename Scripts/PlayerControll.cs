using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    Vector3 V3force;

    [SerializeField]
    KeyCode keyPositive;
    
    [SerializeField]
    KeyCode keyNegative;

    [SerializeField]
    KeyCode Jump;
    
    public Rigidbody rb;
        private void start()
    {
        rb = GetComponent<Rigidbody>();
    
    }

    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
        GetComponent<Rigidbody>().velocity+=V3force;

        if (Input.GetKey(keyNegative))
        GetComponent<Rigidbody>().velocity-=V3force;

       if (Input.GetKeyDown(Jump))
        GetComponent<Rigidbody>().velocity = V3force;
 
    
    }

}
 