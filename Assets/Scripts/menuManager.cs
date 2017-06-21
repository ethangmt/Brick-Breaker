using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Input.mousePosition.x);
		if (Input.GetMouseButton(0) && Input.mousePosition.x < 360) {
			SceneManager.LoadScene ("mainScene");
		}

		//TODO use for other levels
	}
}
