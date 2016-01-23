using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class warpLevel : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if( col.gameObject.tag == "level001finish")
		{
			SceneManager.LoadScene (2);
		}
		if( col.gameObject.tag == "level002finish")
		{
			SceneManager.LoadScene (3);
		}
		if( col.gameObject.tag == "level003finish")
		{
			SceneManager.LoadScene (4);
		}
		if( col.gameObject.tag == "level004finish")
		{
			SceneManager.LoadScene (5);
		}
		if( col.gameObject.tag == "level005finish")
		{
			SceneManager.LoadScene (6);
			//PlayerPrefs.GetInt("score") = 0;
		}

	}
}
