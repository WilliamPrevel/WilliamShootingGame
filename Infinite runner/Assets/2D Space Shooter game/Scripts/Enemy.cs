﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public static int player_score = 0;
    public int Health = 100;

    public void TakeDamage (int damage)
    {
        Health -= damage;

        if(Health <= 0)
        {
            Die();
        }
<<<<<<< HEAD
        

=======
>>>>>>> parent of d108919... made a smart AI
    }

     void Die()
    {
        player_score += 15;
        Destroy(gameObject);
    }
}
