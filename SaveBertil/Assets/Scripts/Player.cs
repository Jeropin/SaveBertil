using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int score = 0;
    public class player
    {
        public int health;
        public int bullets;

        public player( int hea, int bul)   
        {
            health = hea;
            bullets = bul;
        }

        public player()
        {
            health = 5;
            bullets = 5;
        }

    }

    public player bertil = new player();
}
