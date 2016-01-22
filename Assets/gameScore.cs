using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameScore : MonoBehaviour {

	public Text scoreText;
	public GameObject gem;
	private int score;
	// Use this for initialization
	void Start () {

		score = 0;
		UpdateScore ();
	}

	public void AddScore (int newScoreValue)
	{
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore ()
	{
		scoreText.text = "Score: " + score;
	}
		

	// Update is called once per frame
	void Update () {
	
	}
}
