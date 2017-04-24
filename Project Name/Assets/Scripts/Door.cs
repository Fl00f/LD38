using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public bool DisablePot = false;
	public GameObject pot;
	public int LevelNeededForDoor;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<Player>()) {

			if (col.gameObject.GetComponent<Player>().GetCurrentLevel() >= LevelNeededForDoor) {
				if (DisablePot) {
					pot.SetActive (false);
				}
				gameObject.SetActive (false);
			}


		}
	}
}
