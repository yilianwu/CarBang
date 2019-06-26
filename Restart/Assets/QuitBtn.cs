using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class QuitBtn : MonoBehaviour {
	private Button btn;
	// Use this for initialization
	void Start () {
		btn = GetComponent<Button> ();
		btn.onClick.AddListener (BtnClick);
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void BtnClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
		Time.timeScale=0;
		//Application.Quit();
	}

}
