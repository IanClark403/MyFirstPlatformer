using UnityEngine;
using System.Collections;

public class gem_Rotate : MonoBehaviour {

	void Update () {
		transform.Rotate (Vector3.up, 5, Space.World);
	}
}
