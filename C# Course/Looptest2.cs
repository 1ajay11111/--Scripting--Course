using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looptest2 : MonoBehaviour
{
    public GameObject[] Objects;

   
    void Start()
    {
        foreach(GameObject o in Objects)
        {
            o.SetActive(true);


           /* Destroy(o);*/
        }
    }

    void Update()
    {
        
    }
}
