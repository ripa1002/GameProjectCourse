using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Player") {
			Destroy (col.gameObject);
			Debug.Log ("Congratulations! You managed to die!");
		}
	}
}
