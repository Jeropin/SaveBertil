using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler : MonoBehaviour
{
    string sceneName;
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    public void gameOver() 
    {
        if (sceneName != "TutorialScene")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void win()
    {
        SceneManager.LoadScene("WinScene");
    }

    public void play()
    {
        Player.score = 0;
        SceneManager.LoadScene("PlayScene");
    }

    public void tutorial()
    {
        Player.score = 0;
        SceneManager.LoadScene("TutorialScene");
    }
}
