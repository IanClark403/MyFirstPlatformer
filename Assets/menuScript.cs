using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas volumeMenu;
	public Button startText;
	public Button exitText;
	public Button volumeText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		volumeMenu = volumeMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		volumeText = volumeText.GetComponent<Button> ();

		quitMenu.enabled = false;
		volumeMenu.enabled = false;
	}

	public void ExitPress (){

		quitMenu.enabled = true;
		startText.enabled = false;
		volumeText.enabled = false;
		exitText.enabled = false;
	}
	public void VolumePress () {

		volumeMenu.enabled = true;
		startText.enabled = false;
		volumeText.enabled = false;
		exitText.enabled = false;
	}
	public void NoPress(){

		quitMenu.enabled = false;
		startText.enabled = true;
		volumeText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel(){

		Application.LoadLevel (1);
	}
	public void donePress(){
		volumeMenu.enabled = false;
		startText.enabled = true;
		volumeText.enabled = true;
		exitText.enabled = true;
	}
	public void ExitGAme(){

		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
