using UnityEngine;

public class MoveOnTouch : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;

    private bool moving;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moving Platform")
        {
            this.transform.parent = collision.transform;
            print("test");
        }
    }

        void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag =="Moving Platform")
            {
                this.transform.parent = null;
                print("test2");
            }
        }
}
