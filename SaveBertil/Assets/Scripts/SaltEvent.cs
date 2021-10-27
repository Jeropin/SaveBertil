using System.Collections;
using UnityEngine;

public class SaltEvent : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GetComponent<Player>();

    }

    //Subtract from player's health when hit by salt
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            player.bertil.health--;
        }
    }
}
