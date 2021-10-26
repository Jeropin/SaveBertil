using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEvent : MonoBehaviour
{
    private GameObject playerObject;
    private Player player;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        player = playerObject.GetComponent<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Collectible")
        {
            player.bertil.score--;
            Debug.Log(player.bertil.score);
        }

        if(collision.gameObject.tag == "Enemy")
        {
            player.bertil.score++;
            Debug.Log(player.bertil.score);
        }
    }
}
