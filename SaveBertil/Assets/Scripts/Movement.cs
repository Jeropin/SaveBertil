using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;
    public Vector2 movement;
    bool move = false;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            movement = new Vector2(Input.GetAxis("Horizontal"), 0);
            move = true;
        }
        else
        {
            move = false;
        }
    }

    private void FixedUpdate()
    {
        movePlayer(movement);
    }

    void movePlayer(Vector2 direction)
    {
        if (move)
        {
            rb.velocity = direction * speed;
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }

}
