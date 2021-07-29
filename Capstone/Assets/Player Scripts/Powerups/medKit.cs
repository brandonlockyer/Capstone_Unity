using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medKit : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D medkit)
    {
        if (medkit.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        Health player = medkit.GetComponent<Health>();
        if (player != null)
        {
            player.Heal(50);
        }
    }











}
