﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This Rigidbody can be assigned from the Unity window
    public Rigidbody rb;

    // Can be overriden by Unity from Inspector
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    // Use FixedUpdate for physics
    void FixedUpdate()
    {
        // Moves forward
        // deltaTime is the time since last frame was drawn.
        // use this to get consistent force that is not dependent on FPS
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}