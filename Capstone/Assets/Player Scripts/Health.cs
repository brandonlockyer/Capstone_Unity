using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;


    public HealthBar healthBar;
    private Animator myAnimator;


    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            TakeDamage(20);
        }
        if (currentHealth <= 0)
        {
            myAnimator.SetBool("Dead", true);
            Invoke("Die", 2);
        }
    }


    void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.gameObject.tag == "Enemy")
        {
            TakeDamage(10);
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
