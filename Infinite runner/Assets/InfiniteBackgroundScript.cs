using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackgroundScript : MonoBehaviour {

    Material Background;
    Vector2 Change;

    public float xVelocity, yVelocity;


    private void Awake()
    {
        Background = GetComponent<Renderer>().material;
    }

    // Use this for initialization
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Change = new Vector2(xVelocity, yVelocity);
        Background.mainTextureOffset += Change * Time.deltaTime;
	}
}
