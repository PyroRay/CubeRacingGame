using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fwdForce = 1000f;
    public float sideForce = 30f;
    public float updownForce = 20f;

    private void Update()
    {        

    }

    // Update is called once per specific time
    void FixedUpdate()
    {
        // add specific amount of forward force
        rb.AddForce(0, 0, fwdForce * Time.deltaTime);

        // allows for control of left and right movement
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (!(Input.GetKeyDown("d")))
        {
            if (rb.velocity.x > 0)
            {
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (!(Input.GetKeyDown("a")))
        {
            if (rb.velocity.x < 0)
            {
                rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, updownForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        else if (!(Input.GetKeyDown("w")))
        {
            if (rb.velocity.y > 0)
            {
            rb.AddForce(0, -updownForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -updownForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        else if (!(Input.GetKeyDown("s")))
        {
            if (rb.velocity.y < 0)
            {
                rb.AddForce(0, updownForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }

    }
}
