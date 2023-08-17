using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
     public float Speed;
    Rigidbody rb;
    float inputX, inputY;
    public int jumpforce;
    bool jump = false;
    public float bulletSpeed;
    bool shoot = false;
    public GameObject bullet;
    public Transform bulletpos;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
     //   rb.velocity = new Vector3(0, 0, Speed);
    }
    void Update()
    {
         inputX = Input.GetAxis("Horizontal");
         inputY = Input.GetAxis("Vertical");
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetMouseButtonDown(0))
        {
            shoot = true;

        }

    }
        void FixedUpdate()
    {
        rb.velocity = new Vector3(inputX * Speed, rb.velocity.y, inputY * Speed);
        if(jump== true )
        {
            Jump();
            jump = false; 
        }
        if(shoot==true)
        {
            Shoot();
            shoot = false;
        }
    }
    void Jump()
    {
        rb.AddForce(0, jumpforce, 0);
    }
    void Shoot()
    {
       GameObject bulletSpawn =  Instantiate(bullet, bulletpos.position, bullet.transform.rotation);

        bulletSpawn.GetComponent<Rigidbody>().velocity = new Vector3(0,0,bulletSpeed);

    }
}
