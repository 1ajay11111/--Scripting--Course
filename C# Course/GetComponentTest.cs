using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTest : MonoBehaviour
{ Rigidbody rb;
    Color ren;
    PlayerHealth health;


    // Start is called before the first frame update
    void Start()
    {

        GetComponentInChildren<Rigidbody>().useGravity = true;
       // health = GetComponent<PlayerHealth>();
       // health.lives = 9;
       // rb = GetComponent<Rigidbody>();
      //  rb.useGravity = false;
       // rb.mass = 10;
      //ren = GetComponent<Renderer>().material.color = Color.blue ;
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
