using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueEvent : MonoBehaviour
{
    SceneHandler sceneHandler;
    string sceneName;
    void Start()
    {
        sceneHandler = GetComponent<SceneHandler>();
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            if (sceneName == "TutorialScene")
            {
                sceneHandler.play();
            }
            if(sceneName == "IntroScene")
            {
                sceneHandler.tutorial();
            }
            if(sceneName == "GameOverScene")
            {
                sceneHandler.play();
            }
            if (sceneName == "WinScene")
            {
                sceneHandler.play();
            }

        }
    }
}
