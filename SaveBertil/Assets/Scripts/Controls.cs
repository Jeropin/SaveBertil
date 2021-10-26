using System.Collections;
using UnityEngine;

//I think this is pretty bad in terms of coding the movement since it is all over the place. Spaghetti.
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

    void Update()
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

    private void FixedUpdate()
    {
        movePlayer(movement);

        if (shoot)
        {
            shooting();
            shoot = false;
        }
    }

    //Spawns a bullet
    void shooting()
    {
        Instantiate(bullet, transform.position + new Vector3(0.0f,1.0f,0.0f), transform.rotation);
    }

    //Controls the player
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
