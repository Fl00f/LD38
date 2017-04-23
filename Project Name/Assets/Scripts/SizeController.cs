using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour {
	public float sizeReductionStep = .99f;
	public float FinalSizeReduction = .8f;
	SphereCollider col;
	// Use this for initialization
	void Start () {
		col = GetComponent<SphereCollider> ();
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Space)) {
			ReduceSize ();
		}
	}
	
	public void ReduceSize(){
		StartCoroutine (SizeReduciton ());
	}


	IEnumerator SizeReduciton(){
		Vector3 originalScale = transform.localScale;
		bool isDoneReducingSize = false;
		while (!isDoneReducingSize) {
			yield return new WaitForEndOfFrame ();
			transform.localScale *= sizeReductionStep;
			col.radius = col.radius * sizeReductionStep;

			if (transform.localScale.x <= originalScale.x *FinalSizeReduction) {
				isDoneReducingSize = true;
			}
		}

	}
}
