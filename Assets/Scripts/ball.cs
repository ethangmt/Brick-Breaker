using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public float speed = 30;
	Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		speedUp ();
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.name == "paddle") {
			handlePaddleHit (col);
		}

		if (col.gameObject.name == "wallBottom") {
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

	public void speedUp () {
		GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed;
	}

	public void freeze () {
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
	}

	public void resume () {
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation;
		speedUp ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
