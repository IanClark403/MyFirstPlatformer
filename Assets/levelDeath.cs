using UnityEngine;
using System.Collections;

public class levelDeath : MonoBehaviour {

	public GameObject player;
	public GameObject respawnPoint;

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "death") 
		{
			player.transform.position = respawnPoint.transform.position;
		}
	}
}
