using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTransition : MonoBehaviour {

	public Animator anim;
	public LetterManager letMan;

	public GameObject player;

	public CanvasGroup fadeImage;

	public float fadeDur = 100;

	public bool runOnce;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Fade ();
	}

	void Fade(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Fade Transition")) {
			fadeImage.alpha += (Time.deltaTime / fadeDur);
			if (fadeImage.alpha >= 1 && runOnce == true) {
				anim.SetBool ("Interact", false);
				Debug.Log("adding Letters");
				letMan.letterSet += 1;
				Debug.Log(letMan.letterSet);
				letMan.Translate ();
				RotatePlayer ();
				runOnce = false;
			}
		}
		else if (anim.GetCurrentAnimatorStateInfo (0).IsName ("New State")) {
			fadeImage.alpha -= (Time.deltaTime / fadeDur);
			runOnce = true;
		}
	}

	void RotatePlayer(){
		Quaternion playerTrans = player.transform.rotation;
		playerTrans.y = 0;
		player.transform.rotation = new Quaternion(player.transform.rotation.x, playerTrans.y, player.transform.rotation.z, player.transform.rotation.w);
	}
}