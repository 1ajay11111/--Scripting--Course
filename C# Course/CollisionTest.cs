using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        { Destroy(collision.gameObject); }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //  if (other.CompareTag("Enemy"))
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}




}
