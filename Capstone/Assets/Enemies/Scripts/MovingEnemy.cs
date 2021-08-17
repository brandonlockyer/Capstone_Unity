using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    public Transform Player;
    public float speed = 5f;
    public Rigidbody2D rb;
    private Animator myAnimator;
    public float detectionRange = 10;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }



    public void Update()
    {
        if (Vector3.Distance(Player.position, transform.position) <= detectionRange)
        {

                Move();
        }
    }


    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        myAnimator.SetBool("isMoving", true);
    }
}
