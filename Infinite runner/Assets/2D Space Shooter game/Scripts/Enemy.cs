using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int player_score = 0;
    public int ScoreWorth = 15;
    public int Health = 100;
    public int DestroyPointOnYAxis = -10;
   
    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Die();
        }
    }
    private void Update()
    {
        if (transform.position.y <= -DestroyPointOnYAxis)
        {
            Destroy(gameObject);
        }
    }

    void Die()
    {
        player_score += ScoreWorth;
        Destroy(gameObject);
    }
}
