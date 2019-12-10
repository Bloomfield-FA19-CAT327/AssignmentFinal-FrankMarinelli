using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public float counterTime;
	public Text counterText;
	public GameObject player;
	public GameObject respawnPoint;
	public Text deathCount;
	public int timesDied = 0;
	public Canvas winner;
	private bool gameRun = false;

	public void Start() {
		gameRun = true;
		winner.enabled = false;

	}


	private void Update() {
		if (gameRun) {
		}
		counterTime += Time.deltaTime;
		counterText.text = "Time: " + Mathf.Round(counterTime).ToString();

	}


	//code used is from a previous project from a different class. Its changed around for this assignment.

	private void OnTriggerEnter(Collider other) {
	
	}
	
	public void ResetPlayer() {
		player.gameObject.SetActive(false);
		player.gameObject.transform.position = respawnPoint.gameObject.transform.position;
		player.gameObject.SetActive(true);
		//Credit to Professor Pollati's sample project.
	}

	public void Win() {
		winner.enabled = true;
		gameRun = false;
	} //Credit to Professor Pollati's sample project


}