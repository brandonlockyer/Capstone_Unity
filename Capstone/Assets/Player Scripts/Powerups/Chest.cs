using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public SpriteRenderer closedSprite;
    public Sprite openSprite;
    public Transform player;
    public GameObject item;
    private bool isOpen = false;
    public Transform itemLocation;

    void Update()
    {

        if (Vector3.Distance(player.position, transform.position) <= 3f)
        {
            if (Input.GetButtonDown("Interact") && isOpen == false)
            {
                Open();
                isOpen = true;
            }
        }





    }

    void Open()
    {
        closedSprite.sprite = openSprite;
        Instantiate(item, itemLocation.position, itemLocation.rotation);
    }





}
