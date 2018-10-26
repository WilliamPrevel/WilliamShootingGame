using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounds : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15f, 15f),
            Mathf.Clamp(transform.position.y, -5f, 4f), transform.position.z);
    }
}
