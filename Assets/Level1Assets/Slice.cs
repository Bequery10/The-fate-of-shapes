using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
     public Rigidbody rb;
    void Start()
    {
        rb.AddForce(0, 000, -2000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
