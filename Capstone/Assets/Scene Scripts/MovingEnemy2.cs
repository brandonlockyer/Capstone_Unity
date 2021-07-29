using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy2 : MonoBehaviour
{
    public float position1 = 0;
    public float position2 = 0;
    // Start is called before the first frame update
    float dirX, moveSpeed = 3f;
    bool moveRight = true;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > position1)
            moveRight = false;
        if (transform.position.x < position2)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
