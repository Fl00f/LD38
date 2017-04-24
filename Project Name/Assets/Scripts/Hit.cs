using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
	AudioSource audioSource;
	AudioClip  clip;
	void Start(){
		if (GetComponent<AudioSource>() == null) {
			audioSource = gameObject.AddComponent<AudioSource> ();
		}
		clip = Resources.Load<AudioClip> ("Player_Takes_Damage");
		audioSource.clip = clip;
		audioSource.playOnAwake = false;
		audioSource.loop = false;
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.GetComponent<Player>()) {
			audioSource.Play ();
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
