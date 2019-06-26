using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class center : MonoBehaviour {
	private Fireball number = new Fireball();
	public SerialPort sp = new SerialPort ("COM5",9600);
	void Start () {
		sp.Open ();
	}
	
	// Update is called once per frame
	void Update () {


		if(sp.IsOpen && this.gameObject == null){
			
			
				Debug.Log ("打開了");
			
					sp.Write ("0");
					print ("0");
					Debug.Log ("1");



		}
	}
		

}