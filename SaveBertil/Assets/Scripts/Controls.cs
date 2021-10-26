using System.Collections;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 10;
    public Rigidbody2D rb;
    public Vector2 movement;
    bool move = false;
    bool shoot = false;


    void Start()
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

        if (Input.GetKeyDown("space"))
        {
            shoot = true;
        }
    }

    void shooting()
    {
        Instantiate(bullet, transform.position + new Vector3(0.0f,1.0f,0.0f), transform.rotation);
        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    private void FixedUpdate()
    {
        movePlayer(movement);

        if (shoot)
        {
            shooting();
            shoot = false;
        }
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
