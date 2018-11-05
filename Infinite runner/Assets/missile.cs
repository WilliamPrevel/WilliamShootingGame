using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class missile : MonoBehaviour
{
    public Transform LockOn;
    public float Speed = 5f;
    public float rotateSpeed = 190f;
    private Rigidbody2D RB;
	// Use this for initialization
	void Start ()
    {
      RB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
        Vector2 direction = (Vector2)LockOn.position - RB.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        RB.angularVelocity = -rotateAmount * rotateSpeed;
        RB.velocity = transform.up * Speed;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
