using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 80f;
    bool jump = false;
    bool crouch = false;
    private Animator myAnimator;
    bool grounded = false;
    public Transform GroundCheck;
    public LayerMask groundLayer;
    public float sprintSpeed = 130f;

    public DialogueUI DialogueUI => dialogueUI;
    [SerializeField] private DialogueUI dialogueUI;

    float horizontalMove = 0f;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (dialogueUI.IsOpen) return;

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;


        grounded = Physics2D.OverlapCircle(GroundCheck.position, 0.15f, groundLayer);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            runSpeed = sprintSpeed;
            myAnimator.SetBool("Running", true);
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            runSpeed = 80f;
            myAnimator.SetBool("Running", false);
        }

        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            myAnimator.SetBool("Walk", true);
        }

        else
        {
            myAnimator.SetBool("Walk", false);
        }

        if (grounded == false)
        {
            myAnimator.SetBool("Jump", true);
        }

        else
        {
            myAnimator.SetBool("Jump", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
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
