using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomHit : MonoBehaviour {

    int mushCount = 0;
    private void Start()
    {
        Debug.Log("Script start");
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(){
		Debug.Log ("Mushroom count col");
	}
        
    void OnTriggerEnter(Collider col){
        mushCount++;
        Debug.Log ("Mushroom count "+mushCount);
        Destroy(col.gameObject);
        //Destroy(col.gameObject);
	}
}
