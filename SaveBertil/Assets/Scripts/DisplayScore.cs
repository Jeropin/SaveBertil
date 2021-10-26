using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text text;

    void Update()
    {
        text.text = Player.score.ToString();
    }
}
