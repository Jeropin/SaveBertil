using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public class player
    {
        public int score;
        public int health;
        public int bullets;

        public player(int sco, int hea, int bul)   
        {
            score = sco;
            health = hea;
            bullets = bul;
        }

        public player()
        {
            score = 0;
            health = 5;
            bullets = 5;
        }

    }

    public player bertil = new player();
}
