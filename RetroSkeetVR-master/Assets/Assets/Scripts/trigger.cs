using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    void OnTriggerExit(Collider s)
    {
        Debug.Log("Enter hit-1");
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter hit-2");


    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay hit-3");
    }
}
