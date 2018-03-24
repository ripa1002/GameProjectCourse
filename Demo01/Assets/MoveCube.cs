using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {
	public float speed = 1.0f;
	private BoxCollider _boxCollider;
	private bool directionChanger = true;

	// Use this for initialization
	void Start () {
		_boxCollider = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (this._boxCollider.transform.position.x < -20.42f) {
			this.directionChanger = false;
		}
		if (this._boxCollider.transform.position.x > 7.0f) {
			this.directionChanger = true;
		}
		if (this._boxCollider.transform.position.x > -20.42f && directionChanger) {
			transform.Translate (speed * -1, 0, 0, Space.World);
		} else {
			transform.Translate (speed, 0, 0, Space.World);
		}

	}
}
