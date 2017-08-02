using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractManager : MonoBehaviour {

	public Transform playerCam;
	public RaycastHit rayHit;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		ShootRay ();	
	}

	void ShootRay(){
		Ray interactRay = new Ray(transform.position, (playerCam.forward * 10));
		Debug.DrawRay (transform.position, (playerCam.forward * 10));
		if (Physics.Raycast (interactRay, out rayHit)) {
			if (rayHit.distance < 10) {
				rayHit.transform.gameObject.GetComponent<ObjectInteract> ().isTargeted = true;
			} else
				return;
		}
	}		
}