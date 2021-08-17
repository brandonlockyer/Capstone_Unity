using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Transform Player;
    private bool facingRight = false;
    public Collider2D hitBox;
    public Animator enemy;


    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            enemy.SetBool("isDead", true);
            hitBox.enabled = false;
            Invoke("Die",1);
        }
    }

    public void Update()
    {
      if (Player.transform.position.x < gameObject.transform.position.x && !facingRight){
            Flip();
        }
      if (Player.transform.position.x > gameObject.transform.position.x && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        gameObject.transform.Rotate(0f, 180f, 0f);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
