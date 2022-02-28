using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyPosition : MonoBehaviour
{
    [SerializeField]
Transform TransTarget;
    void Update()
    {
        transform.position = TransTarget.position;
    }
}
