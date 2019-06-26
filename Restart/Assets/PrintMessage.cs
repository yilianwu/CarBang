using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMessage : MonoBehaviour {
	
	[SerializeField] private GameObject fireballPrefab;
	private GameObject myfireball;
	[SerializeField] private GameObject car;

	public void start(){

	}


	// Use this for initialization
	public void PrintActivateMessage(){
		print ("Activated");
		myfireball = Instantiate (fireballPrefab) as GameObject;
		myfireball.transform.position = transform.TransformPoint (Vector3.forward * 2.0f); //+ Vector3.up * 0.25f);
		myfireball.transform.rotation = transform.rotation;

		Vector3 point = new Vector3 (car.transform.position.x, car.transform.position.y, car.transform.position.z);
	}

	public void PrintDeactivateMessage(){
		print ("Deactivated");
	}


	private IEnumerator Dis(){
		
		yield return new WaitForSeconds (2);
		Destroy (myfireball);
	}
}
