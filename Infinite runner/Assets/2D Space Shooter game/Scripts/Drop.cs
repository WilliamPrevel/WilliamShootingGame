﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{


    public float fallSpeed = 8.0f;
    public float spinSpeed = 250.0f;
    private float leftRightSpeed = Random.Range(-10f, 10f);

    void Update()
    {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward, leftRightSpeed * Time.deltaTime);

    }
}