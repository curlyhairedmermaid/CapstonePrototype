﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cion : MonoBehaviour {

    public float rotateSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 50), rotateSpeed * Time.deltaTime, Space.World);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    }
