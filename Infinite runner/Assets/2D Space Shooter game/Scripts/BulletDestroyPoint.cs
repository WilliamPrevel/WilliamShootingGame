using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyPoint : MonoBehaviour {

    //Public Variables
    public GameObject theBulletDestroyPoint;

    //Private Variables

    // Use this for initialization
    void Start()
    {
        theBulletDestroyPoint = GameObject.Find("BulletDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > theBulletDestroyPoint.transform.position.y)
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);

        }

    }
}
