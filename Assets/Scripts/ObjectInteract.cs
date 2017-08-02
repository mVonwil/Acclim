using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour {

	InteractManager intMan;

	public GameObject obj;
	public bool isTargeted;
	public Color originalColor;

	// Use this for initialization
	void Start () {
		intMan = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<InteractManager> ();
		originalColor = obj.GetComponent<Renderer> ().material.color;
	}
	
	// Update is called once per frame
	void Update () {
		ChangeColor ();
		if (intMan.rayHit.transform.gameObject != this.gameObject)
			isTargeted = false;
	}

	public void ChangeColor(){
		if (isTargeted == true)
			obj.GetComponent<Renderer> ().material.color = Color.green;
		else
			obj.GetComponent<Renderer> ().material.color = originalColor;
	}
}
