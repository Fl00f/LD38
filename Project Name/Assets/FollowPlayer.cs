using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	Player player;
	Vector3 playerPos;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		playerPos = player.transform.position;
		playerPos.z = -10;
		transform.position = playerPos;
	}
	
	// Update is called once per frame
	void Update () {
		playerPos = player.transform.position;
		playerPos.z = -10;
		transform.position = playerPos;
	}
}
