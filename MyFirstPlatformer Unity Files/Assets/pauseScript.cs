using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour {

	public Canvas pauseMenu;


	// Use this for initialization
	void Start () {
		pauseMenu = pauseMenu.GetComponent<Canvas> ();

		//initalizes canvas menus as hidden
		pauseMenu.enabled = false;
	}
	public void ExitGAme(){

		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
