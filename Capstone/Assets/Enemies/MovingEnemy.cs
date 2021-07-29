using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Transform Player;
    private bool facingRight = false;
    public float speed = 5f;
    public Rigidbody2D rb;
    private Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }



    public void Update()
    {
        if (Vector3.Distance(Player.position, transform.position) <= 100f)
        {
            if (Player.transform.position.x < gameObject.transform.position.x && !facingRight)
            {
                Move();
            }
            if (Player.transform.position.x > gameObject.transform.position.x && facingRight)
            {
                Move();
            }
        }
    }


    void Move()
    {
        rb.velocity = transform.right * speed;
        myAnimator.SetBool("isMoving", true);
    }
}
