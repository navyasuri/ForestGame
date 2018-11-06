using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHit : MonoBehaviour {

	int mushroomCounter;

	void onCollisionEnter(){

		mushroomCounter++;
		Debug.Log ("Mushroom count" + mushroomCounter);
	}

	void onTriggerEnter(Collision col){
		mushroomCounter++;
		Debug.Log ("Mushroom count" + mushroomCounter);
	}
}
