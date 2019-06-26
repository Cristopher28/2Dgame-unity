using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharecterMovment : MonoBehaviour
{
    public float maxspeed = 6.0f;
    public bool facingrigth = true;
    public float movemenDirection;
    private Rigidbody rigidbody;
    public Animator animator;
    //variable para el salto 
    public float SpeedJump = 600.0f;
    //variable para deteccion de piso 
    public bool ground = false;
    public Transform GroundCheck;
    public float Ground_Radius = 0.5f;
    public LayerMask WhatIsGround;

     void Awake()
    {
        GroundCheck = GameObject.Find("GroundCheck").transform;
    }




    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movemenDirection = Input.GetAxis("Horizontal");
        if (ground && Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("IsJumping");
            rigidbody.AddForce(new Vector2(0, SpeedJump));
            
        }
    }

    void FixedUpdate()
    {
        ground = Physics2D.OverlapCircle(GroundCheck.position, Ground_Radius, WhatIsGround);
        rigidbody.velocity = new Vector2(maxspeed * movemenDirection, rigidbody.velocity.y);
        if(movemenDirection > 0.0f && !facingrigth)
        {
            flip();
        }else if(movemenDirection < 0.0f && facingrigth)
        {
            flip();
        }
        animator.SetFloat("Speed", Mathf.Abs(movemenDirection));
    }

    void flip()
    {
        facingrigth = !facingrigth;
        transform.Rotate(Vector3.up, 180.0f, Space.World);
    }

}
