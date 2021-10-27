using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject playerObject;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.velocity = Vector2.down * 3;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Bertil")
        {
            Invoke("delayGameFinish", 0.3f);
        }
    }

    void delayGameFinish()
    {
        playerObject.GetComponent<SceneHandler>().win();
    }
}
