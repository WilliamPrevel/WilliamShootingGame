﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject Player;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(Player);
    }
}
