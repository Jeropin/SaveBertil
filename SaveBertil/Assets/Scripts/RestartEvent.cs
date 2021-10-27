using System.Collections;
using UnityEngine;

public class RestartEvent : MonoBehaviour
{
    SceneHandler sceneHandler;
    void Start()
    {
        sceneHandler = GetComponent<SceneHandler>();
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            sceneHandler.play();
        }
    }
}
