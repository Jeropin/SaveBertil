using System.Collections;
using UnityEngine;

public class DestroyObjectTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        Object.Destroy(collision.gameObject);
    }
}
