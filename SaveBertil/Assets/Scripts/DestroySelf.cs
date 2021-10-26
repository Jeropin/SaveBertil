using System.Collections;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
