using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour {

	InteractManager intMan;

	public Animator anim;
	public GameObject obj;
	public bool isTargeted;
	public Color originalColor;
	public bool stopColor;
	public bool buttonPress;

	// Use this for initialization
	void Start () {
		intMan = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<InteractManager> ();
		originalColor = obj.GetComponent<Renderer> ().material.color;
	}

	// Update is called once per frame
	void Update () {
		//ChangeColor ();
		RunInteract ();
		if (intMan.obj == this.gameObject)
			isTargeted = true;
		else
			isTargeted = false;;
	}
	/*
	public void ChangeColor(){
		if (isTargeted == true && intMan.rayHit.transform.gameObject == this.gameObject)
			obj.GetComponent<Renderer> ().material.color = Color.green;
		else
			obj.GetComponent<Renderer> ().material.color = originalColor;
	}
	*/

	void RunInteract(){
		if (isTargeted == true && buttonPress == true && anim.GetBool ("Interact") == false) {
			anim.SetBool ("Interact", true);
		} else if (isTargeted == true && buttonPress == true && anim.GetBool ("Interact") == true) {
			anim.SetBool ("Interact", false);
		} else
			return;
	}
}