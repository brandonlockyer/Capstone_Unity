using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    float dirX, moveSpeed = 3f;
    bool moveRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 33.5f)
            moveRight = false;
        if (transform.position.x < 30.5f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
