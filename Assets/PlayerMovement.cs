using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fwdForce = 2000f;
    public float sideForce = 2000f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        // add specific amount of forward force
        rb.AddForce(0, 0, fwdForce * Time.deltaTime);

        // allows for control of left and right movement
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
