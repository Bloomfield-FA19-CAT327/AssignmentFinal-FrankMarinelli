using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalWin : MonoBehaviour {
	public GameController gameController;

	public void OnTriggerEnter(Collider other) {
		gameController.Win();
	}//Credit to Professor Pollati's sample project
}
