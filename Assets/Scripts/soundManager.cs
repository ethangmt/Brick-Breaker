using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

	public static soundManager instance = null;
	private AudioSource source = null;

	public AudioClip paddleHit;
	public AudioClip brickHit;
	public AudioClip wallHit;
	public AudioClip die;
	public AudioClip timer;

	// Use this for initialization
	void Start () {
		if (instance == null) {
			instance = this;
		}
		else if (instance != this) {
			Destroy (instance);
		}

		source = GetComponent<AudioSource> ();
	}

	public void PlayOneShot (AudioClip sound) {
		source.PlayOneShot (sound);
	}
}
