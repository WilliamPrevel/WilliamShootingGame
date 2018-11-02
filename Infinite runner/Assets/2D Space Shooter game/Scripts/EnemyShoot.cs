using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float Speed;

    private Transform Ship;
    private Vector2 Target;
	// Use this for initialization
	void Start ()
    {
        Ship = GameObject.FindGameObjectWithTag("Player").transform;
        Target = new Vector2(Ship.position.x, Ship.position.y);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target, Speed * Time.deltaTime);
        if (transform.position.x == Target.x && transform.position.y == Target.y)
        {
            Vanish();
        }
	}

    public void Vanish()
    {
        Destroy(gameObject);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Vanish();
        }
    }
}
