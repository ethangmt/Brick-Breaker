using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

	public GameObject brickPrefab;

	public Sprite timer2;
	public Sprite timer1;

	// Use this for initialization
	void Start () {

		StartCoroutine ("startTimer");

		float startx = -51;
		float starty = 10;
		float xchange = 6;
		float ychange = 4;
		for (int j = 0; j < 7; j++)
		{
			for (int i = 0; i < 18; i++) {
				GameObject brick = Instantiate (brickPrefab, new Vector2(startx + (xchange * i), starty - (ychange * j)), Quaternion.identity);
				brick.GetComponent<Renderer> ().material.SetColor ("_Color", new Color(Random.value, Random.value, Random.value));
			}
		}
	}

	IEnumerator startTimer () {
		GameObject ball = GameObject.Find ("ball");
		ball.GetComponent<ball> ().freeze ();

		GameObject timer = GameObject.Find ("timer");

		yield return new WaitForSecondsRealtime (1f);
		timer.GetComponent<SpriteRenderer>().sprite = timer2;
		yield return new WaitForSecondsRealtime (1f);
		timer.GetComponent<SpriteRenderer>().sprite = timer1;
		yield return new WaitForSecondsRealtime (1f);

		Destroy (timer);
		ball.GetComponent<ball> ().resume ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
