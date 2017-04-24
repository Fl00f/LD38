using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerSpawn : MonoBehaviour {
	public int Level;
	Player player;
	bool hasBeenTriggered = false;
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
		if (!hasBeenTriggered) {
			player.AddToHighestLevelCompleted (Level);
			player.GetComponent<SizeController> ().ReduceSize ();
			Camera.main.orthographicSize -= 2;
			hasBeenTriggered = true;
		}
		yield return new WaitForSeconds (1);
		player.TeleportToSpawn ();
	}
}
