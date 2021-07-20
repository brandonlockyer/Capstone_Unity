using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    private Animator myAnimator;
    

    float horizontalMove = 0f;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        myAnimator.SetFloat("VSpeed", Input.GetAxis("Vertical"));

        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            myAnimator.SetBool("Walk", true);
        }
        else
        {
            myAnimator.SetBool("Walk", false);
        }


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            myAnimator.SetBool("Jump", true);
        }
        else
        {
            myAnimator.SetBool("Jump", false);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
          
        } 
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
           
        }

        if (crouch == true)
        {
            myAnimator.SetBool("Crouching", true);
        }
        else
        {
            myAnimator.SetBool("Crouching", false);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }
}
