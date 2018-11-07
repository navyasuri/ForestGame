using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomDestory : MonoBehaviour {

	public AudioClip collectSound;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(){
		Debug.Log ("len" + collectSound.length);
		Debug.Log ("Audio" + gameObject.GetComponent<AudioSource> ());
		audio.PlayOneShot(collectSound, 0.8f);
		GetComponent<Renderer> ().enabled = false;
		Destroy (gameObject, collectSound.length);
	}
}
