using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

	public GameObject brickPrefab;
	public Color[] colors;

	// Use this for initialization
	void Start () {
		float startx = -51;
		float starty = 10;
		float xchange = 6;
		float ychange = 4;
		for (int i = 0; i < 5; i++) {
			GameObject brick = Instantiate (brickPrefab, new Vector2(startx + (xchange * i), starty), Quaternion.identity);
			brick.GetComponent<SpriteRenderer> ().color = Color.blue;//colors[Random.Range(0, colors.Length)];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
