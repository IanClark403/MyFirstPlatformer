using UnityEngine;
using System.Collections;

public class finishMenu : MonoBehaviour {

	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Escape)) {
			
			Application.Quit ();
		}
	}  
}