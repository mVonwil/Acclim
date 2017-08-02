using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public GameObject head;

	public float moveSpeed = 20;
	public float lookSpeed = 200;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		PlayerMove ();
	}

	void PlayerMove(){
		float moveUpDown = Input.GetAxis ("Vertical") * moveSpeed * Time.deltaTime;
		float moveLeftRight = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
		transform.Translate (moveUpDown, 0, moveLeftRight);
		float lookUpDown = Input.GetAxis ("Mouse Y") * lookSpeed * Time.deltaTime;
		float lookLeftRight = Input.GetAxis ("Mouse X") * lookSpeed * Time.deltaTime;
		head.transform.Rotate (-lookUpDown, lookLeftRight, 0);

	}
}
