using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XboxCtrlrInput;

public class PlayerMovement : MonoBehaviour {

	InteractManager intMan;
	UIManager pauseMan;

	public GameObject body;

	public Vector3 upDown;
	public float yMax;
	public float yMin;

	public float moveSpeed = 1;
	public float lookSpeed = 1;

	public float lookHori;
	public float lookVert;
	public float addLookHori;
	public float addLookVert;

	public bool invertY;

	// Use this for initialization
	void Start () {
		intMan = GetComponent<InteractManager> ();
		//pauseMan = GameObject.FindGameObjectWithTag ("PauseMenu").GetComponent<UIManager> ();
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		RightBumper ();
		InvertY ();
		QuitButton ();
	}

	void FixedUpdate(){
		BugTest ();
		PlayerMove ();
		PlayerLook ();
	}

	void PlayerMove(){

		Vector3 newPosition = body.transform.position;

		float moveHori = XCI.GetAxis (XboxAxis.LeftStickX);
		float moveVert = XCI.GetAxis (XboxAxis.LeftStickY);

		if (moveHori > 0)
			body.transform.position += (body.transform.right * moveHori * moveSpeed * Time.deltaTime);
		else if (moveHori < 0)
			body.transform.position += (body.transform.right * moveHori * moveSpeed * Time.deltaTime);
		if (moveVert > 0)
			body.transform.position += (body.transform.forward * moveVert * moveSpeed * Time.deltaTime);
		else if (moveVert < 0)
			body.transform.position += (body.transform.forward * moveVert * moveSpeed * Time.deltaTime);
	}

	void PlayerLook(){

		Quaternion bodyLook = body.transform.rotation;

		lookHori = XCI.GetAxis (XboxAxis.RightStickX);
		lookVert = XCI.GetAxis (XboxAxis.RightStickY);

		addLookHori += (lookHori * lookSpeed * Time.deltaTime);
		if (invertY == true)
			addLookVert += (lookVert * lookSpeed * Time.deltaTime);
		else
			addLookVert += (-lookVert * lookSpeed * Time.deltaTime);

		if (addLookVert < -85)
			addLookVert = -85;
		else if (addLookVert > 45)
			addLookVert = 45;

		transform.eulerAngles = new Vector3 (addLookVert, addLookHori, 0);
		
		body.transform.eulerAngles = new Vector3 (0, addLookHori, 0);
	}

	void RightBumper(){
		if (XCI.GetButtonDown (XboxButton.RightBumper))
			intMan.buttonPress = true;
		else
			intMan.buttonPress = false;
	}
		//if (XCI.GetButtonDown (XboxButton.Start))
			//pauseMan.TogglePauseMenu ();
	void InvertY(){
		if (XCI.GetButtonDown (XboxButton.Y)) {
			if (invertY == false)
				invertY = true;
			else
				invertY = false;
		}
	}

	void QuitButton(){
		if (XCI.GetButtonDown (XboxButton.Back))
			Application.Quit ();
	}

	void BugTest(){
		upDown = transform.position;
		if (XCI.GetButton (XboxButton.X)) {
			if (upDown.y < yMax)
				upDown += (Vector3.up / 50);
			else
				upDown.y = yMax;
			
		}
		if (XCI.GetButton (XboxButton.B)) {
			if (upDown.y > yMin)
				upDown -= (Vector3.up / 50);
			else
				upDown.y = yMin;
		}
		transform.position = upDown;
	}
}