using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carshootiog : MonoBehaviour {

	[SerializeField] public GameObject fireballPrefab;
	public GameObject myfireball;

	private Camera _camera;
	// Use this for initialization
	void Start () {
		_camera = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButtonDown(0)) {
			//myfireball = Instantiate (fireballPrefab) as GameObject;
			//myfireball.transform.position = transform.TransformPoint (Vector3.forward * 1.5f + Vector3.up * 0.25f);
			//myfireball.transform.rotation = transform.rotation;

			//Vector3 point = new Vector3 (2, 0, 0);

			//Ray ray = _camera.ScreenPointToRay (point);
			//RaycastHit hit;

			//if (Physics.Raycast (ray, out hit)) {
				//GameObject hitObject = hit.transform.gameObject;
			//}
	}
}


