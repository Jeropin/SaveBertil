using System.Collections;
using UnityEngine;

public class WaterEvent : MonoBehaviour
{

    //Add to player score when it hits water
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            Player.score++;
        }
    }
}
