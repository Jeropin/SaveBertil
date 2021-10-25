using System.Collections;
using UnityEngine;

public class WaterEvent : MonoBehaviour
{
    private Player player;
    private void Start()
    {
        player = GetComponent<Player>();

    }

    //Add to player score when it hits water
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            player.bertil.score++;
            Debug.Log(player.bertil.score);
        }
    }
}
