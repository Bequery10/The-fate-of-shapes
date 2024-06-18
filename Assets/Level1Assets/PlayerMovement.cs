using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce=500f;
    public float jumpForce=5f;
    public float distanceToGround = 0.6f;
    void Start()
    {
       rb.useGravity = true;
       rb.AddForce(0, 000, 200);
    }

    bool isGrounded = false;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime,ForceMode.VelocityChange);
         isGrounded = Physics.Raycast(transform.position, -Vector3.up, distanceToGround);

        if (Input.GetKey("space") && isGrounded)
        {
            rb.AddForce(0, 1000*jumpForce * Time.deltaTime, 0);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(3*forwardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-3*forwardForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
    }
}
