﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementArrow : MonoBehaviour {

    // Use this for initialization
    public Transform cam;
    private Rigidbody body;
	void Start () {
        body = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveAround();
        //makes player jump
        if (Input.GetButtonDown("Jump"))
        {
            body.AddForce(Vector3.up*7, ForceMode.Impulse);
        }
    }
    /// <summary>
    /// Moves Around the players
    /// </summary>
    private void MoveAround()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 ballForward = cam.forward;
        ballForward.y = 0;
        ballForward.Normalize();

        Vector3 ballRight = new Vector3(ballForward.z, 0, -ballForward.x);

        Vector3 move = ballForward * v + ballRight * h;
        Vector3 torque = Vector3.Cross(Vector3.up, move);
        //body.AddForce(move * Time.deltaTime * 2500);
        body.AddTorque(torque * Time.deltaTime * 100000);
    }
}