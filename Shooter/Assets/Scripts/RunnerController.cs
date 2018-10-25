﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Infinite._Runner_Start

{
    public class RunnerController : MonoBehaviour
    {
        private bool Jump;
        private Rigidbody2D rb2d;
        public float Speed = 5f;



        // Use this for initialization
        void Start()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //if(!Jump)
            //{
            //  Jump = Input.GetButtonDown("Jump");
            // Debug.Log("Jumped!");
            //}
            //float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector2(moveHorizontal,0);
            rb2d.AddForce(movement * Speed);
        }
    }

}