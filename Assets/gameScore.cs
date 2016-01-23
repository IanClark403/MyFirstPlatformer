using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameScore : MonoBehaviour {

	public Text scoreText;
	private int score;
	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt ("score") == 0) 
		{
			score = 0;
		}
		if (PlayerPrefs.GetInt ("score") != 0) 
		{
			score = PlayerPrefs.GetInt("score");
		}
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
		PlayerPrefs.SetInt("score", score);
	}
		
}
