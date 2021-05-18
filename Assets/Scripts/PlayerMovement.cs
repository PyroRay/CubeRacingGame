using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float fwdForce = 1000f;
    public float sideForce = 30f;
    public float updownForce = 20f;
    public Vector3 playerAngles;
    public Transform player;

    // Update is called once per specific time
    void FixedUpdate()
    {
        // add specific amount of forward force
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, fwdForce);

        // assigns player's rotation angles to variable
        playerAngles = player.rotation.eulerAngles;

        // allows for control of left and right movement
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            player.Rotate(0, 2, 0);
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
            player.Rotate(0, -2, 0);
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
            player.Rotate(-2, 0, 0);
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
            player.Rotate(2, 0, 0);
        }
        else if (!(Input.GetKeyDown("s")))
        {
            if (rb.velocity.y < 0)
            {
                rb.AddForce(0, updownForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }


        if (rb.angularVelocity.x > 0)
        {
            rb.angularVelocity = new Vector3(rb.angularVelocity.x - 0.05f, 0, 0);
        }
        if (rb.angularVelocity.x < -0)
        {
            rb.angularVelocity = new Vector3(rb.angularVelocity.x + 0.05f, 0, 0);
        }
        if (rb.angularVelocity.y > 0)
        {
            rb.angularVelocity = new Vector3(0, rb.angularVelocity.y - 0.05f, 0);
        }
        if (rb.angularVelocity.y < -0)
        {
            rb.angularVelocity = new Vector3(0, rb.angularVelocity.y + 0.05f, 0);
        }
        if (rb.angularVelocity.z > 0)
        {
            rb.angularVelocity = new Vector3(0, 0, rb.angularVelocity.z - 0.05f);
        }
        if (rb.angularVelocity.z < -0)
        {
            rb.angularVelocity = new Vector3(0, 0, rb.angularVelocity.z + 0.05f);
        }


        if (playerAngles.x > 1 && playerAngles.x < 180)
        {
            player.Rotate(-1, 0, 0);  
        }
        if (playerAngles.x > 180 && playerAngles.x < 359)
        {
            player.Rotate(1, 0, 0);
        }
        if (playerAngles.y > 1 && playerAngles.y < 180)
        {
            player.Rotate(0, -1, 0);
        }
        if (playerAngles.y > 180 && playerAngles.y < 359)
        {
            player.Rotate(0, 1, 0);
        }
        if (playerAngles.z > 1 && playerAngles.z < 180)
        {
            player.Rotate(0, 0, -1);
        }
        if (playerAngles.z > 180 && playerAngles.z < 359)
        {
            player.Rotate(0, 0, 1);
        }

    }
}
