using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouchExplode : MonoBehaviour
{
    private Animator myAnimator;
    public int damage = 50;
    public Collider2D hitBox;
    public Rigidbody2D rb;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            Health player = hitInfo.GetComponent<Health>();
            if (player != null)
            {                
                player.TakeDamage(damage);
                hitBox.enabled = false;
                myAnimator.SetBool("isDead", true);
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                Invoke("Die", 1);
            }
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }
}
