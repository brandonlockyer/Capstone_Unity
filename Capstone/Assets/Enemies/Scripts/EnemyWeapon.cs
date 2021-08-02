using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform player;
    public float TimeBetweenShots = 5f; //Delay between attacks
    private float timeSinceLastShot = 0f; //How long since last attack
    private Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }
 
    
    
    // Update is called once per frame
    void Update()
    {
        timeSinceLastShot = timeSinceLastShot + Time.deltaTime; //increment the cooldown every second
        if (Vector3.Distance(player.position, transform.position) <= 20f)
        {
            myAnimator.SetBool("playerInRange", true);
        }



        if (timeSinceLastShot >= TimeBetweenShots)
        {
            if (Vector3.Distance(player.position, transform.position) <= 20f)
            {
                
                Shoot();
                timeSinceLastShot = 0f; //reset the cooldown
            }
            else
            {
                myAnimator.SetBool("playerInRange", false);
            }
        }
    }



    void Shoot()
    {
        //Shoots stuff
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
