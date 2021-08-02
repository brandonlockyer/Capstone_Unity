using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public Transform Player;

    public int spawnDistance;
    private Animator enemyAnimator;
    private bool Alive = false;
    public float moveSpeed = 3f;
    private bool inRange = false;



    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }


    void Update()
    {
        if (inRange == false)
        {
            if (Vector3.Distance(Player.position, this.transform.position) <= spawnDistance)
            {
                inRange = true;
                enemyAnimator.SetBool("isAlive", true);
                Invoke("isActive", 1);
            }
        }
        if (Alive == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, moveSpeed * Time.deltaTime);
        }
    }



    void isActive()
    {
        Alive = true;
        enemyAnimator.SetBool("isMoving", true);
    }
}
