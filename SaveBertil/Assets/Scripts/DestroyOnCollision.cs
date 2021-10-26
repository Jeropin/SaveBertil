using System.Collections;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectible" || collision.gameObject.tag == "Enemy")
        {
            Object.Destroy(collision.gameObject);
        }
    }
}
