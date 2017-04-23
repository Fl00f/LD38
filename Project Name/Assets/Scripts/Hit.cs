using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {


	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<Player>()) {
			col.gameObject.GetComponent<Player> ().ToggleMovement (false);
			StartCoroutine (TeleportPlayer (col.gameObject.GetComponent<Player> ()));

		}
	}

	IEnumerator TeleportPlayer(Player player){
		player.GetComponent<Rigidbody> ().isKinematic = true;
		yield return new WaitForSeconds (1);
		player.TeleportToSpawn ();
	}
}
