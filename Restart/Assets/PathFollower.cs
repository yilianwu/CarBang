using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour {
	public Transform[] path;
	public float speed = 0.2f;
	public float reachDist = 10.0f;
	public int currentPoint = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector3 dir = path [currentPoint].position - transform.position;
		//  dir /= dir.magnitude;
		//print (dir);
		//print (dir.magnitude);
		transform.position += dir * speed * Time.deltaTime;
		if (dir.magnitude < reachDist) {
			currentPoint++;
		}
		if (currentPoint >= path.Length) {
			currentPoint = 0;
		}
	}
	void OnDrawGizmos(){
		if (path.Length > 0)
			for (int i = 0; i < path.Length; i++) {
				if (path [i] != null) {
					Gizmos.DrawSphere (path [i].position, reachDist);
				}

			}
	}
}