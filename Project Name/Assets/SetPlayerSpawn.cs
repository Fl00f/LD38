using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerSpawn : MonoBehaviour {
	public Transform SetPlayerSpawnTo;

	void OnTriggerEnter(Collider col){

		if (col.GetComponent<Player>()) {
			col.GetComponent<Player> ().TeleportLocation = SetPlayerSpawnTo;
		}
	}

}
