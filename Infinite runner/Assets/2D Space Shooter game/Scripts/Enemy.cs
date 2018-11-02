using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public static int player_score = 0;
    public int Health = 100;
    public GameObject destroyPoint;

    public void Update()
    {
        if (Health <= 0)
        {
            Die();
        }
        else if (transform.position.y <= destroyPoint.transform.position.y)
        {
            //Destroy(gameObject);
            Health = 0;
            gameObject.SetActive(false);

        }
    }

    public void TakeDamage (int damage)
    {
        Health -= damage;
    }

     void Die()
    {
        player_score += 15;
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
