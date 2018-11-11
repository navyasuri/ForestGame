using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawner : MonoBehaviour {

	Vector3 startPos = Vector3.zero;

	// Use this for initialization
	void Start () {
		startPos = GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -20) {
			gameObject.transform.position = startPos;
		}
	}
}
