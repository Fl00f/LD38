using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour {
	public Text WinText;

	void OnCollisionEnter(Collision col){
		WinText.gameObject.SetActive (true);
	}
}
