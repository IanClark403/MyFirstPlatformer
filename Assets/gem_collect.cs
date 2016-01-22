using UnityEngine;
using System.Collections;


public class gem_collect : MonoBehaviour {

	public AudioSource other;
	public int scoreValue;

	void OnTriggerEnter() 
	{
		other.GetComponent<AudioSource>().Play ();
		Destroy (gameObject);	
	}
}