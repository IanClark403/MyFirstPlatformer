using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Slider volumeSlider;
	public Canvas volumeMenu;
	public Button startText;
	public Button exitText;
	public Button volumeText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		volumeMenu = volumeMenu.GetComponent<Canvas> ();
		//volumeSlider = volumeSlider.GetComponent<Slider> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		volumeText = volumeText.GetComponent<Button> ();

		//initalizes canvas menus as hidden
		quitMenu.enabled = false;
		volumeMenu.enabled = false;

		//Call player preferences to set audio volume
		AudioListener.volume = PlayerPrefs.GetFloat ("CurVolume");
		volumeSlider.value = AudioListener.volume;
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

	public void VolumeControl()
	{
		AudioListener.volume = volumeSlider.value;

		if(volumeSlider)
			PlayerPrefs.SetFloat("CurVolume", AudioListener.volume);
	}
	public void NoPress(){

		quitMenu.enabled = false;
		startText.enabled = true;
		volumeText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel(){

		//Application.LoadLevel (1);
		SceneManager.LoadScene(1);
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
