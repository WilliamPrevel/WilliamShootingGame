using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartAI : MonoBehaviour
{
    public float speed;
    public float StopDistance;
    public float LeaveDistance;

    private float ShotTimer;
    public float ShotTimer2;

    public GameObject Shots;
    private Transform Ship;
	// Use this for initialization
	void Start ()
    {
        Ship = GameObject.FindGameObjectWithTag("Player").transform;
        ShotTimer = ShotTimer2;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Vector2.Distance(transform.position, Ship.position) > StopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Ship.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, Ship.position) < StopDistance && Vector2.Distance(transform.position, Ship.position) > LeaveDistance)
        {
            transform.position = this.transform.position;
        }
        
        if(ShotTimer <= 0)
        {
            Instantiate(Shots, transform.position, Quaternion.identity);
            ShotTimer = ShotTimer2;
        }
        else
        {
            ShotTimer -= Time.deltaTime;
        }
	}
}
