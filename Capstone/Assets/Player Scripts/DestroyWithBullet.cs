using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
