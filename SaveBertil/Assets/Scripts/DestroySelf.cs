using System.Collections;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        Destroy(gameObject, 1.0f);
    }
}
