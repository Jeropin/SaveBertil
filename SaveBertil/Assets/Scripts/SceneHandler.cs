using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneHandler : MonoBehaviour
{
    public void gameOver() 
    {
        SceneManager.LoadScene("GameOverScene");
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
}
