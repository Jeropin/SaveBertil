using System.Collections;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float speed = 3;

    void Start()
    {
        bullet = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        bullet.velocity = Vector2.up * speed;
    }
}
