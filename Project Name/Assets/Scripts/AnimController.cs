using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			if (!anim.GetBool("Left")) {
				anim.SetBool ("Left",true);

				anim.SetBool ("Right",false);
				anim.SetBool ("Up",false);
				anim.SetBool ("Down",false);
			}
		}
		if (Input.GetKey(KeyCode.D)) {
			if (!anim.GetBool("Right")) {
				anim.SetBool ("Right",true);

				anim.SetBool ("Left",false);
				anim.SetBool ("Up",false);
				anim.SetBool ("Down",false);
			}
		}
		if (Input.GetKey(KeyCode.W)) {
			if (!anim.GetBool("Up")) {
				anim.SetBool ("Up",true);

				anim.SetBool ("Left",false);
				anim.SetBool ("Right",false);
				anim.SetBool ("Down",false);
			}
		}
		if (Input.GetKey(KeyCode.S)) {
			if (!anim.GetBool("Down")) {
				anim.SetBool ("Down",true);

				anim.SetBool ("Left",false);
				anim.SetBool ("Right",false);
				anim.SetBool ("Up",false);
			}
		}
	}
}
