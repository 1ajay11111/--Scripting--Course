using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float Speed;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))      // When Pressed Space Key
        //{
        //    print(" Space Button Pressed First Time");
        //    GetComponent<Renderer>().material.color = Color.green;
        //}
        //if (Input.GetKeyUp(KeyCode.Space))     // When Pressed Key Released
        //{
        //    GetComponent<Renderer>().material.color = Color.yellow;

        //    print(" Space Button Released");
        //}
        //if (Input.GetKey(KeyCode.Space))     // When Space Key Kept Pressed
        //{
        //    print(" Space Button Held Down");
        //}

        //if(Input.GetButtonDown("Jump"))
        //{
        //    print(" Space Button Pressed First Time");
        //    GetComponent<Renderer>().material.color = Color.green;
        //}

        //float xInput = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        //float yInput = Input.GetAxis("Vertical") * Speed * Time.deltaTime; ;
        //print(xInput);
        //transform.Translate(xInput, yInput, 0);

       //if( Input.GetButtonDown("Fire1"))
       // {
       //     print(" left mouse Button clicked ");
       // }

        //if(Input.GetMouseButtonDown(0))
        //{
        //    print("left Click");
        //    print("x="+ Input.mousePosition.x + "   "+"y="+ Input.mousePosition.y);

        //    Vector3 pos = Input.mousePosition;
        //    pos.z = 10f;

        //   pos =  Camera.main.ScreenToWorldPoint(pos);
        //    Instantiate(ball, pos, Quaternion.identity);



        //}
        //if (Input.GetMouseButtonDown(1))
        //{
        //    print("Right Click");
        //}
        //if (Input.GetMouseButtonDown(2))
        //{
        //    print("Wheel Click");
        //}

    }
    // void OnMouseDown()
   // {
       // Destroy(gameObject);
   // }
}
