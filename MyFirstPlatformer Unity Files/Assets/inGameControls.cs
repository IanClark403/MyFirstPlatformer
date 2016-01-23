using UnityEngine;
using System.Collections;

public class inGameControls : MonoBehaviour {

	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			
			Application.Quit ();
		}
	}  
}