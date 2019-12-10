using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour {
	private GameController gameController;

	 void Start() {
		gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
	}

	private void OnTriggerEnter(Collider other) {
		gameController.ResetPlayer();
		//Code from Professor Pollati's sample project
	}
}
