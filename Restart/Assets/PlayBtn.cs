using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayBtn : MonoBehaviour {
	private Button btn;
	//public GameObject mypanel;
	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
		btn = GetComponent<Button> ();
		btn.onClick.AddListener (BtnClick);
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		int btnstate = GameObject.Find ("ButtonState").GetComponent<Button_all> ().move01;
		if (btnstate == 1) {
			//mypanel.SetActive (false);
			//SceneManager.LoadScene (SceneManager.GetActiveScene().name);
			BtnClick();
		}
	}
	void BtnClick(){
		
		//SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Time.timeScale = 1;
	}
}
