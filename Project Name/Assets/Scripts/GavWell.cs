using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GavWell : MonoBehaviour {
	Player player;
	Rigidbody playerRB;

	Vector3 heading;
	Vector3 direction;
	public float GravityStrength = 100;

	void Start(){
		player =FindObjectOfType<Player> ();
		playerRB = player.GetComponent<Rigidbody> ();
	}
	void Update(){
		heading = player.transform.position - transform.position;
		direction = heading / heading.magnitude;
	}

	void OnTriggerStay(Collider col){
		if (col.gameObject == player.gameObject) {
			playerRB.AddForce (-direction * GravityStrength);
		}
	}
}
