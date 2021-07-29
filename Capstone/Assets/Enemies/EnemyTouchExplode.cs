using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouchExplode : MonoBehaviour
{

    public int damage = 50;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        print("shit works");
        if (hitInfo.gameObject.tag == "Player")
        {
            Health player = hitInfo.GetComponent<Health>();
            if (player != null)
            {
                player.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
    }
}
