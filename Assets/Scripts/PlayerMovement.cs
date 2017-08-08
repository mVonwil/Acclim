using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerMovement : MonoBehaviour {

	InteractManager intMan;

	public GameObject body;

	public float moveSpeed = 1;
	public float lookSpeed = 1;

	public float lookHori;
	public float lookVert;
	public float addLookHori;
	public float addLookVert;

	// Use this for initialization
	void Start () {
		intMan = GetComponent<InteractManager> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		PlayerMove ();
		PlayerLook ();
		Buttons ();
	}

	void PlayerMove(){

		Vector3 newPosition = body.transform.position;

		float moveHori = XCI.GetAxis (XboxAxis.LeftStickX);
		float moveVert = XCI.GetAxis (XboxAxis.LeftStickY);

		float addMoveHori = (moveHori * moveSpeed * Time.deltaTime);
		float addMoveVert = (moveVert * moveSpeed * Time.deltaTime);

		newPosition = new Vector3 (addMoveHori, 0, addMoveVert);

		body.transform.position += newPosition;
		/*
		float axisX = XCI.GetAxis (XboxAxis.LeftStickX);
		float axisY = XCI.GetAxis (XboxAxis.LeftStickY);

		float newPosX = newPosition.x + (axisX * moveSpeed * Time.deltaTime);
		float newPosZ = newPosition.z + (axisY * moveSpeed * Time.deltaTime);

		newPosition = new Vector3 (newPosX, 1, newPosZ);
		body.transform.localPosition = newPosition;
		*/
	}

	void PlayerLook(){

		Quaternion newLook = transform.rotation;
		Quaternion bodyLook = body.transform.rotation;

		lookHori = XCI.GetAxis (XboxAxis.RightStickX);
		lookVert = XCI.GetAxis (XboxAxis.RightStickY);

		addLookHori += (lookHori * moveSpeed * Time.deltaTime);
		addLookVert += (lookVert * moveSpeed * Time.deltaTime);

		if (addLookVert >= .45f)
			addLookVert = .45f;
		if (addLookVert < -.85f)
			addLookVert = -.85f;

		newLook = new Quaternion (addLookVert, addLookHori, 0, transform.rotation.w);

		transform.rotation = newLook;

		bodyLook.y = newLook.y;
		body.transform.rotation = bodyLook;
		/*
		float axisY = XCI.GetAxis (XboxAxis.RightStickX);
		float axisX = XCI.GetAxis (XboxAxis.RightStickY);

		float newLookX = newLook.x + (axisX * lookSpeed * Time.deltaTime);
		float newLookY = newLook.y + (axisY * lookSpeed * Time.deltaTime);

		newLook = new Quaternion (newLookX, newLookY, 0, transform.rotation.w);

		transform.localRotation = newLook;
		*/
	}

	void Buttons(){
		if (XCI.GetButtonDown(XboxButton.RightBumper))
			intMan.buttonPress = true;
		else
			intMan.buttonPress = false;
	}
}