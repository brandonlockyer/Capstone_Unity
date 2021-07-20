using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy_AI : MonoBehaviour
{

    public Transform BirdEnemyIdleSprite;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;




    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(BirdEnemyIdleSprite);

        if (Vector3.Distance(transform.position, BirdEnemyIdleSprite.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, BirdEnemyIdleSprite.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }

        }
    }
}