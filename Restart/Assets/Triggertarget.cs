using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggertarget : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider ohter){
		Debug.Log ("Trigger : "+ohter.name);

		if (ohter.gameObject.name == "male") {
			Destroy (this.gameObject);
		}
	}
}
