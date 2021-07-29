using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float TimeBetweenShots = 5f; //Delay between attacks
    private float speedHolder;
    private float timeSinceLastShot = 0f; //How long since last attack



    void Start()
    {
        speedHolder = TimeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastShot = timeSinceLastShot + Time.deltaTime;
        if (timeSinceLastShot >= TimeBetweenShots)
        {
            if (Input.GetButton("Fire1"))
            {
                timeSinceLastShot = 0f;
                Shoot();
            }
        }
    }


    public void FastShoot()
    {
        TimeBetweenShots = 0.1f;
        Invoke("powerupTimer", 5);

    }


   void powerupTimer()
    {
        TimeBetweenShots = speedHolder;
    }


    void Shoot()
    {
        //Shoots stuff
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
