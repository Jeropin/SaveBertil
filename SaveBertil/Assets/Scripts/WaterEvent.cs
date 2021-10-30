using System.Collections;
using UnityEngine;

public class WaterEvent : MonoBehaviour
{
    public GameObject SFX;

    //Add to player score when it hits water
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible")
        {
            SFX.GetComponent<SFXLibrary>().playWaterGet();
            Player.score++;
        }
    }
}
