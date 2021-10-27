using System.Collections;
using UnityEngine;

//I think this is pretty bad in terms of coding the movement since it is all over the place. Spaghetti.
public class Controls : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody2D rb;
    public Vector2 movement;
    Player player;
    public float speed = 10;
    int maxBullet;
    bool move = false;
    bool shoot = false;


    void Start()
    {
        player = GetComponent<Player>();
        maxBullet = player.bertil.bullets;
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

    void FixedUpdate()
    {
        movePlayer(movement);

        if (shoot)
        {
            shooting();
            shoot = false;
        }
    }
    
    //Bullet will be reloaded
    void reload()
    {
        if(player.bertil.bullets != maxBullet) player.bertil.bullets++;
    }

    //Spawns a bullet
    void shooting()
    {
        if (player.bertil.bullets != 0)
        {
            player.bertil.bullets--;
            Instantiate(bullet, transform.position + new Vector3(0.0f, 1.0f, 0.0f), transform.rotation);
            Invoke("reload", 1.0f);
        }
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
