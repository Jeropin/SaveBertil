using System.Collections;
using UnityEngine;

//Put on hold will figure out a way to do this later
public class BulletEvent : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Collectible")
        {
            Player.score--;
        }

        if(collision.gameObject.tag == "Enemy")
        {
            Player.score++;
        }
    }
}