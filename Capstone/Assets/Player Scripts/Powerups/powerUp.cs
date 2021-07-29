using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D powerup)
    {
        if (powerup.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        Weapon player = powerup.GetComponent<Weapon>();
        if (player != null)
        {
            player.FastShoot();
        }
    }











}
