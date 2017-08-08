using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractManager : MonoBehaviour {

	public Transform playerCam;
	public RaycastHit rayHit;
	public GameObject obj;
	public Text onScreen;
	public bool buttonPress;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		ShootRay ();
		OnScreenText ();
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}

	void ShootRay(){
		Ray interactRay = new Ray(transform.position, (playerCam.forward * 10));
		Debug.DrawRay (transform.position, (playerCam.forward * 10));
		if (Physics.Raycast (interactRay, out rayHit)) {
			if (rayHit.distance < 5 && rayHit.transform.gameObject.GetComponent<ObjectInteract>() == true) {
				obj = rayHit.transform.gameObject;
				obj.GetComponent<ObjectInteract> ().isTargeted = true;
				if (buttonPress == true)
					obj.GetComponent<ObjectInteract> ().buttonPress = true;
				else 
					obj.GetComponent<ObjectInteract> ().buttonPress = false;
			} else
				return;
		} else
			return;
	}

	void OnScreenText(){
		if (rayHit.transform.gameObject.tag == "Interact") {
			string objHit = rayHit.transform.gameObject.name;
			onScreen.text = objHit;
		} else
			onScreen.text = "";
	}
}