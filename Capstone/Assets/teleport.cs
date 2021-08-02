using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform Player;
    public Transform Target;



    void Update()
    {
        if (Vector3.Distance(Player.position, transform.position) <= 5f)
        {
            if (Input.GetButtonDown("Interact"))
            {
                Player.position = Target.position;
            }
        }
    }
}
