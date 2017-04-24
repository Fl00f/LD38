using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public int LevelNeededForDoor;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<Player>()) {
			if (col.gameObject.GetComponent<Player>().GetCurrentLevel() >= LevelNeededForDoor) {
				gameObject.SetActive (false);
			}
		}
	}
}
