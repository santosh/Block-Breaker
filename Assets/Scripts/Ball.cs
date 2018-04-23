using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;
    private bool hasStarted = false;
    private Vector3 paddleToBallVector;
    private Rigidbody2D ballRigidbody;

    // Use this for initialization
    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        ballRigidbody = GetComponent<Rigidbody2D>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }
    
    // Update is called once per frame
    void Update () {
        if (!hasStarted) {
            // Constrain ball to the paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            // Wait for LMB click and start the game
            if (Input.GetMouseButtonDown(0)) {
                Debug.Log("Launching ball.");
                hasStarted = true;
                ballRigidbody.velocity = new Vector2(2f, 15f);
            }
        }
    }
    void FixedUpdate(){ Debug.Log("Ball velocity: " + ballRigidbody.velocity.magnitude); }
}
