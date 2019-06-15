﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterMovment : MonoBehaviour
{
    public float maxspeed = 6.0f;
    public bool facingrigth = true;
    public float movemenDirection;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movemenDirection = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(maxspeed * movemenDirection, rigidbody.velocity.y);
        if(movemenDirection > 0.0f && !facingrigth)
        {
            flip();
        }else if(movemenDirection < 0.0f && facingrigth)
        {
            flip();
        }
    }

    void flip()
    {
        facingrigth = !facingrigth;
        transform.Rotate(Vector3.up, 180.0f, Space.World);
    }

}
