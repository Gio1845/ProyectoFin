using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float maxSpeed = 6.0f;
    public bool facingRigth = true;
    public float moveDirection;
    private new Rigidbody rigidbody;
    private Animator anim;
    bool isJump = false;
    public float jumpForce = 5.0f;
    bool flootDetected = false;
    
    

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
         moveDirection = Input.GetAxis("Horizontal");

        Vector3 floor = transform.TransformDirection(Vector3.down);

        if (Physics.Raycast(transform.position, floor, 1.60f))
        {
            flootDetected = true;
            print("contacto con suelo");
        }
        else 
        {
            flootDetected = false;
            print("no contacto con suelo");
        }

         isJump = Input.GetButtonDown("Jump");

         if(isJump && flootDetected)
         {
             anim.SetTrigger("isJumping");
             rigidbody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
         }
         
    }
    void FixedUpdate() 
    {
        rigidbody.velocity = new Vector2(moveDirection * maxSpeed, rigidbody.velocity.y);
        
        if (moveDirection > 0.0f && !facingRigth) {
            Flip();
        } else if (moveDirection < 0.0f && facingRigth) {
            Flip();
        }
        anim.SetFloat("Speed", Mathf.Abs(moveDirection));
    }

    void Flip ()
    {
        facingRigth = !facingRigth;
        transform.Rotate(Vector3.up, 180.0f, Space.World);
    }
}
