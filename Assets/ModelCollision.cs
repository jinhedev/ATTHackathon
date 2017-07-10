using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelCollision : MonoBehaviour {

	public Canvas canvas;

	void Start () {
		canvas.enabled = false;
	}

	// Use this for initialization
	void OnTriggerEnter (Collider info) {
		if (info.tag == "Player") {
			canvas.enabled = true;
		}
	}

	void OnTriggerExit (Collider info) {
		if (info.tag == "Player") {
			canvas.enabled = false;
		}
	}
}
