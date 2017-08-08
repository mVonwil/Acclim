using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTransition : MonoBehaviour {

	public Animator anim;

	public CanvasGroup fadeImage;

	public float fadeDur = 100;
	public float timer;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Fade ();
	}

	void Fade(){
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("Fade Transition") && anim.GetCurrentAnimatorStateInfo(0).normalizedTime == 1)
			anim.SetBool("Fade", true);
		if (anim.GetBool ("Interact") == true) {
			FadeIn ();
			if (fadeImage.alpha >= 1)
				anim.SetBool ("Interact", false);
		}
		if (anim.GetBool ("Interact") == false && timer >= 2)
			FadeOut ();
	}

	void FadeIn(){
		fadeImage.alpha += (Time.deltaTime / fadeDur);
		timer += Time.deltaTime;
	}

	void FadeOut(){
		//fadeImage.alpha = 1;
		fadeImage.alpha -=  (Time.deltaTime / fadeDur);
		anim.SetBool ("Fade", false);
		timer = 0;
	}

	//void Fade(){
	//	if (anim.GetBool ("Interact") == true) {
	//		if (fadeImage.alpha == 0)
	//			fadeImage.alpha += Time.deltaTime;
	//		else
	//			fadeImage.alpha = 1;
	//	} else {
	//		if (fadeImage.alpha != 0)
	//			fadeImage.alpha -= Time.deltaTime;
	//		else
	//			fadeImage.alpha = 0;
	//	}
	//}

}
