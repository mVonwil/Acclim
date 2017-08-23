using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour {

	public Animator anim;
	public LetterManager letMan;

	public List<string> days;
	public Text dayText;

	//public List<int> timeOfDay;
	//public Vector3 sunRot;
	//public GameObject sun;

	public GameObject player;

	public CanvasGroup fadeImage;

	public float fadeDur = 100;

	public bool runOnce;
	public bool endGame = false;

	// Use this for initialization
	void Start () {
		//anim = GetComponent<Animator> ();
		days.Add("DAY 1");
		days.Add("DAY 2");
		days.Add("DAY 5");
		days.Add("DAY 6");
		days.Add("DAY 7");
		days.Add("DAY 15");
		days.Add("DAY 16");
		days.Add("DAY 21");
		days.Add("DAY 28");

		/*
		timeOfDay.Add (90);
		timeOfDay.Add (0);
		timeOfDay.Add (-10);
		timeOfDay.Add (-20);
		timeOfDay.Add (200);
		timeOfDay.Add (45);
		timeOfDay.Add (120);
		timeOfDay.Add (-90);
		timeOfDay.Add (10);
		timeOfDay.Add (180);
		*/

	}
	
	// Update is called once per frame
	void Update () {
		Fade ();
	}

	void Fade(){
		if (letMan.letterSet < 10) {
			dayText.text = days [letMan.letterSet - 1];
		} else if (letMan.letterSet > 10) {
			dayText.text = ("Thank you for playing.");
			endGame = true;
		}
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Fade Transition")) {
			fadeImage.alpha += (Time.deltaTime / fadeDur);
			if (fadeImage.alpha >= 1 && runOnce == true) {
				if (endGame == true)
					SceneManager.LoadScene(0);
				else {
					anim.SetBool ("Interact", false);
					Debug.Log ("adding Letters");
					letMan.letterSet += 1;
					Debug.Log (letMan.letterSet);
					letMan.Translate ();
					//sunRot = new Vector3(timeOfDay[Random.Range(0, 9)], 0, 0);
					//sun.transform.eulerAngles = sunRot;
					RotatePlayer ();
					runOnce = false;
				}
			}
		} else if (anim.GetCurrentAnimatorStateInfo (0).IsName ("New State")) {
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