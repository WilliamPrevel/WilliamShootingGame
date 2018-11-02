using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyPoint : MonoBehaviour {


    //Public Variables
    public GameObject theEnemyDestroyPoint;

    //Private Variables

    // Use this for initialization
    void Start()
    {
        theEnemyDestroyPoint = GameObject.Find("EnemyDestroyPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > theEnemyDestroyPoint.transform.position.y)
        {
            // Destroy(gameObject);
            gameObject.SetActive(false);

        }

    }
}
