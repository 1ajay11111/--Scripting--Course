using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colour : MonoBehaviour
{
    public GameObject[] objects;
    public int[] Rollnumber;
    public Color[] colours;

    // Start is called before the first frame update
    void Start()
    {
        //  Destroy(objects[2] , 5f);

        objects[2].GetComponent<Renderer>().material.color = colours[1];
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
} 
