using System.Collections;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Object.Destroy(collision.gameObject);
    }
}
