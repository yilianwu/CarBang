using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;

public class state : MonoBehaviour {
	public SerialPort sp = new SerialPort ("COM4",9600);
	private Text mytext ;


	void Start () {
		sp.Open ();
		mytext = GetComponent<UnityEngine.UI.Text> ();
	}
	

	void Update () {
		if (sp.IsOpen) {
			

		
		
			
		if (mytext.text == "1") {
				sp.Write ("0");
				print ("0");
			Debug.Log (mytext.text);
			}
		else if ( mytext.text == "2") {
				sp.Write ("1");
				print ("1");
			Debug.Log (mytext.text);
			}
		else if (mytext.text == "3") {
				sp.Write ("2");
				print ("2");
			Debug.Log (mytext.text);
			}
		else if ( mytext.text == "4") {
				sp.Write ("3");
				print ("3");
			Debug.Log (mytext.text);
			}
		else if ( mytext.text == "5") {
				sp.Write ("4");
				print ("4");
			Debug.Log (mytext.text);
			}
		else if ( mytext.text == "6") {
				sp.Write ("5");
				print ("5");
			Debug.Log (mytext.text);
			}
		else if ( mytext.text == "7") {
				sp.Write ("6");
				print ("6");
			Debug.Log (mytext.text);
			}
		else if ( mytext.text == "8") {
				sp.Write ("7");
				print ("7");
			Debug.Log (mytext.text);

			}
		else if ( mytext.text == "9") {
				sp.Write ("8");
				print ("8");
			Debug.Log (mytext.text);
			}
		else if (mytext.text == "10") {
				sp.Write ("9");
				print ("9");
			Debug.Log (mytext.text);
			}

		}
		

	}
}
