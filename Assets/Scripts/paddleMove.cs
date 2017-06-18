using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleMove : MonoBehaviour {

	public float speed = 30;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h_mov = Input.GetAxisRaw ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2(h_mov, 0) * speed;
	}
}
