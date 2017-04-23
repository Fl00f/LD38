using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerSpawn : MonoBehaviour {

	Player player;

	void Start(){
		player = FindObjectOfType<Player> ();
	}

	void OnTriggerEnter(Collider col){

		foreach (var item in FindObjectsOfType<SpawnPoint>()) {
			if (item.IsMainSpawnPoint) {
				player.TeleportLocation = item.transform;
				StartCoroutine (TeleportPlayer (player));
			}
		}
	}


	IEnumerator TeleportPlayer(Player player){
		yield return new WaitForSeconds (.5f);
		player.TeleportToSpawn ();
	}
}
