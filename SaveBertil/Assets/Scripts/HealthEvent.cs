using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthEvent : MonoBehaviour
{
    public GameObject playerObject;
    private Slider slider;
    private Player player;



    void Start()
    {
        player = playerObject.GetComponent<Player>();
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = player.bertil.health;
    }
}
