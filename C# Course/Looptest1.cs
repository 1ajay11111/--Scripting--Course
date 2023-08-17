using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looptest1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(" Before Entering For Loop ");

        int i = 1;
        while(i<=100)
        {
            // print name 100 times
            print(i);
            i++;
        }

        print(" After Entering For Loop ");

    }

    // Update is called once per frame
  
}
