using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
public class Button_all : MonoBehaviour {
	public SerialPort sp = new SerialPort ("COM4", 9600);
	public int move01 = 0;
	// Use this for initialization
	void Start () {
		sp.Open ();
		//sp.ReadTimeout = 1000;
	}
	void Update(){
		Move ();
	}
	// Update is called once per frame
	void Move () {
		if (sp.IsOpen) {
			string move = sp.ReadLine ();
			if (move == "1") {
				move01 = 1;
				Debug.Log ("!");
			}
			/*if (move == "2") {
				move01 = 2;
				Debug.Log ("!!");
			}
			if (move == "3") {
				move01 = 3;
				Debug.Log ("!!!");
			}
			if (move == "4") {
				move01 = 4;
				Debug.Log ("!!!!");
			}*/
		}
	}
}
