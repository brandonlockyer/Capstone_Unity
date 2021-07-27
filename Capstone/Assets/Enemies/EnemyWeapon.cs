using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform player;
 
    
    
    // Update is called once per frame
    void Update()
    { 
            if (Vector3.Distance(player.position, transform.position) <= 10f)
            {
                Shoot();
            }
    }


    void Shoot()
    {
        //Shoots stuff
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
