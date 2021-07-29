using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDamage : MonoBehaviour
{
    public int damage = 100;
    public Collider2D hitBox;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            Health player = hitInfo.GetComponent<Health>();
            if (player != null)
            {
                player.TakeDamage(damage);
            }
        }
    }
}
