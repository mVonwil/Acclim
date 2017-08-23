using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	Animator anim;

	public Light light1;
	public Light light2;
	public Light light3;

	public GameObject lightOrb1;
	public GameObject lightOrb2;
	public GameObject lightOrb3;

	void Start(){
		anim = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update () {
		LightToggle ();
	}

	void LightToggle(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Lights On")) {
			light1.enabled = false;
			lightOrb1.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			light2.enabled = false;
			lightOrb2.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
			light3.enabled = false;
			lightOrb3.GetComponent<Renderer> ().material.DisableKeyword ("_EMISSION");
		} else {
			light1.enabled = true;
			lightOrb1.GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
			light2.enabled = true;
			lightOrb2.GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
			light3.enabled = true;
			lightOrb3.GetComponent<Renderer> ().material.EnableKeyword ("_EMISSION");
		}
	}
}
