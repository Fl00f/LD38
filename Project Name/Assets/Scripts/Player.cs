using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	int HighestLevelCompleted = 1;
	public Transform TeleportLocation;
	Movement movement;
	// Use this for initialization
	void Start () {
		movement = GetComponent<Movement> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TeleportToSpawn(){
		Debug.Log ("Teleport");
		if (TeleportLocation != null) {
			transform.position = TeleportLocation.position;
			GetComponent<Rigidbody> ().isKinematic = false;

			ToggleMovement (true);
		}
	}

	public void ToggleMovement(bool value){
		movement.enabled = value;
	}

	public void AddToHighestLevelCompleted(int lvl){
			HighestLevelCompleted++;
		
	}
	public int GetCurrentLevel(){
		return HighestLevelCompleted;
	}
}
