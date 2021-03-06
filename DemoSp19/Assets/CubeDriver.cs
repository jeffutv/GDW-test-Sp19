﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDriver : MonoBehaviour {

    public float speed;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h, 0, v) * speed);
	}
}
