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
    public Transform questGiver;
    public Animator npcAnimator;
    private float timeBetweenHits = 1f;
    private float timeSinceLastHit = 0f;
   // public Transform Player;


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
        /*if (Input.GetKeyDown("q"))
        {
            TakeDamage(20);
        }*/
        if (currentHealth <= 0)
        {
            myAnimator.SetBool("Dead", true);
            Invoke("Die", 2);
        }
        if (Input.GetKeyDown("f"))
        {
            if (hasQuestItem == true)
            {
                if (Vector3.Distance(this.transform.position, questGiver.position) <= 3f)
                {
                    hasQuestItem = false;
                    questItem.SetActive(false);
                    npcAnimator.SetBool("hasSandwich", true);
                }
            }
        }


        timeSinceLastHit = timeSinceLastHit + Time.deltaTime;
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

        if (timeSinceLastHit >= timeBetweenHits)
        {
            currentHealth -= damage;
            timeSinceLastHit = 0f;
            healthBar.SetHealth(currentHealth);
        }
    }
}
