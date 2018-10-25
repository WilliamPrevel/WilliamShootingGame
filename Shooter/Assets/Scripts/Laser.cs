using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    public float Speed = 20f;
    public Rigidbody2D RB;
    public int Damage = 40;
	// Use this for initialization
	void Start ()
    {
        RB.velocity = -transform.up * Speed;
	}

    private void OnTriggerEnter2D(Collider2D HitInfo)
    {
        Enemy enemy = HitInfo.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(Damage);
        }
        Destroy(gameObject);
    }


}
