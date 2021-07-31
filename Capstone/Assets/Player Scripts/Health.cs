using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;


    public HealthBar healthBar;
    private Animator myAnimator;
    public GameObject questItem;
    public bool hasQuestItem = false;


    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        questItem.SetActive(false);
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


    public void GetQuestItem()
    {
        hasQuestItem = true;
        questItem.SetActive(true);
    }


    void OnTriggerEnter2D(Collider2D _collision)
    {
        if(_collision.gameObject.tag == "Enemy")
        {
            TakeDamage(10);
        }
    }


    public void Heal(int HP)
    {
        currentHealth += HP;

        healthBar.SetHealth(currentHealth);

        if(currentHealth >= maxHealth)
        {
            currentHealth = 100;
        }
    }


    void Die()
    {
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.name);

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
