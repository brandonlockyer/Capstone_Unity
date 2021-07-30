using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;

    private bool moving;

    void OnCollsionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("MovingPlatform"))
        {
            this.transform.parent = collision.transform;
        }
    }

        void OnCollsionExit2D(Collision2D collision)
        {
            if (collision.gameObject.name.Equals("MovingPlatform"))
            {
                this.transform.parent = null;
            }
        }
}
