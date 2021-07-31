using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public int boost = 60;


    void OnTriggerEnter2D(Collider2D powerup)
    {
        if (powerup.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        
        Weapon playerWeapon = powerup.GetComponent<Weapon>();
        PlayerMovement playerStats = powerup.GetComponent<PlayerMovement>();
        Health playerHUD = powerup.GetComponent<Health>();

        if (playerWeapon != null)
        {
            if (this.gameObject.name == "FireSpeedUp"){

                playerWeapon.FastShoot();

            }

            if (this.gameObject.name == "SpeedUp")
            {
                playerStats.SpeedUp(boost);
            }

            if (this.gameObject.name == "Sandwich")
            {
                playerHUD.GetQuestItem();
            }
        }
    }











}
