﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision");
    }

    void OnTriggerEnter2D(Collider2D trigger) {
        Debug.Log("Trigger");
    }
}
