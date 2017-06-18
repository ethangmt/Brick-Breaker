using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public float speed = 30;
	public Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = Vector2.up * speed;
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.name == "paddle") {
			handlePaddleHit (col);
		}

		if (col.gameObject.name == "wallButtom") {
			// Exit
			Application.Quit ();
		}

		if (col.gameObject.tag == "brick") {
			Destroy (col.collider.gameObject);
		}
	}

	void handlePaddleHit (Collision2D col) {
		float ballX = GetComponent<Transform> ().position.x;
		float paddleX = col.gameObject.GetComponent<Transform> ().position.x;
		float paddleW = col.collider.bounds.size.x;
		float x = (ballX - paddleX) / paddleW;
		rigidBody.velocity = new Vector2 (x, 1) * speed;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
