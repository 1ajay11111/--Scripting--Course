

using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class InstantiateTest : MonoBehaviour

{

    public GameObject[] ball;

    // Start is called before the first frame update

    void Start()

    {

        //Instantiate (ball, transform.position, Quaternion.identity);

        //  Invoke ("RandomBall", 5f);

        InvokeRepeating("RandomBall", 2f, 1f);

    }



    // Update is called once per frame

    void Update()

    {

        if (Input.GetMouseButtonDown(0))

        {
            //  int randomNumber = Random.Range(0, ball.Length);//  0,3 here ball.length means the total size of the ball
            // Instantiate(ball[randomNumber], transform.position, Quaternion.identity);

            CancelInvoke("RandomBall");
            print("Mouse Clicked");

        }



    }
    void RandomBall()
        {

            int randomNumber = Random.Range(0, ball.Length);//  0,3 here ball.length means the total size of the ball



            Instantiate(ball[randomNumber], transform.position, Quaternion.identity);

        }


}