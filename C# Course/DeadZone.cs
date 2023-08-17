using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }

     void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
     void OnTriggerStay(Collider other)
    {
        
    }
}
