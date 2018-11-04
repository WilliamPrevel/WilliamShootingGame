using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI : MonoBehaviour {

    public float speed;
    public float StopDistance;
    public float LeaveDistance;

    private Transform Ship;
    // Use this for initialization
    void Start()
    {
        Ship = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
            transform.position = Vector2.MoveTowards(transform.position, (Ship.position/2), speed * Time.deltaTime);

    }
}
