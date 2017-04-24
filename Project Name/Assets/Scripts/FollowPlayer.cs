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


	float originalSize = 0;
	public void ZoomIn(){
		originalSize = Camera.main.orthographicSize;
		StartCoroutine (StartZoom ());
	}

	IEnumerator StartZoom(){
	
		bool done = false;
		while (!done) {
			yield return new WaitForEndOfFrame ();
			Camera.main.orthographicSize = Camera.main.orthographicSize * .99f;

			if (Camera.main.orthographicSize <= originalSize * .7f) {
				done = true;
			}


		}

	}
}
