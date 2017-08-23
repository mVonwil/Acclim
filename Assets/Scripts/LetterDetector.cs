using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterDetector : MonoBehaviour {

	public GameObject alert;

	public int count;

	void Start(){
		count = 0;
	}

	void Update(){
		if (count == 0)
			alert.SetActive (false);
		else
			alert.SetActive (true);
	}

	void OnTriggerEnter(Collider letter){
		if (letter.gameObject.tag == "Interact") {
			++count;
		}
	}

	void OnTriggerExit(){
		--count;
	}
}