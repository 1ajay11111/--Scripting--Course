using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    public int power = 0;




    // Update is called once per frame
    void Update()
    {
        switch(power)
        {
            case 1:
                print("You r Just a Biginner");
                break;

            case 2:
                print(" Your are intermediate Player");
                break;

            case 3:
                print(" You are Andvanced player");
                break;

            default:
                print("you are not a Player");
                break;
                // it is like "if" concept if not written break after case 1 it will considered as else if after that and default which is written in last it is like else

        }
    }
}
