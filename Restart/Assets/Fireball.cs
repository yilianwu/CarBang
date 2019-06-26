using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fireball : MonoBehaviour {
	public float speed = 200.0f;
	private int n ;
	// Use this for initialization

	public Text text ;


	//public GameObject mytarget ;

	void Start () {
		text = GameObject.Find ("Canvas/Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 1.15f, speed * Time.deltaTime);

	}

	void OnTriggerEnter(Collider ohter){
		//Debug.Log ("Trigger : "+ohter.name);

			if (ohter.gameObject.name == "Target") {
			n = 1;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);


			}
			else if (ohter.gameObject.name == "Target1") {
			n = 2;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}
			else if (ohter.gameObject.name == "Target2") {
			n = 3;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}
			else if (ohter.gameObject.name == "Target3") {
			n = 4;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
		text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}
			else if (ohter.gameObject.name == "Target4") {
			n = 5;

				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}
			else if (ohter.gameObject.name == "Target5") {
			n = 6;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}
			else if (ohter.gameObject.name == "Target6") {
			n = 7;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);


			}
			else if (ohter.gameObject.name == "Target7") {
			n = 8;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);


			}
			else if (ohter.gameObject.name == "Target8") {
			n = 9;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}
			else if (ohter.gameObject.name == "Target9") {
			n = 10;
				Debug.Log ("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
				Destroy (ohter.gameObject);
			text.text=n.ToString();
			Debug.Log (ohter.gameObject.name);

			}


		}


}
