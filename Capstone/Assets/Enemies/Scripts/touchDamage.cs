using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchDamage : MonoBehaviour
{
    public Collider2D hitBox;
    public int damage = 20;
    private Animator myAnimator;

    // Update is called once per frame
    void Update()
    {
        myAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Player")
        {
            Health player = hitInfo.GetComponent<Health>();
            if (player != null)
            {
                player.TakeDamage(damage);
                myAnimator.SetBool("melee", true);
            }
        }
    }
    void LateUpdate()
    {
        myAnimator.SetBool("melee", false);
    }
}
