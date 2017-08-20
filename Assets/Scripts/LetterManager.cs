﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterManager : MonoBehaviour {

	GibberishManager gibMan;

	public List<GameObject> Day1;
	public List<GameObject> Day2;
	public List<GameObject> Day5;
	public List<GameObject> Day6;
	public List<GameObject> Day7;
	public List<GameObject> Day15;
	public List<GameObject> Day16;
	public List<GameObject> Day21;
	public List<GameObject> Day28;

	public int letterSet;

	// Use this for initialization
	void Start () {
		gibMan = GameObject.FindGameObjectWithTag ("GibberishManager").GetComponent<GibberishManager> ();
		letterSet = 1;
		foreach (GameObject letter in Day1) {
			letter.SetActive (true);
		}
	}
	
	// Update is called once per frame
	public void Translate () {
		if (letterSet == 2) {
			foreach (GameObject letter in Day2) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 3) {
			foreach (GameObject letter in Day5) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 4) {
			foreach (GameObject letter in Day6) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 5) {
			foreach (GameObject letter in Day7) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 6) {
			foreach (GameObject letter in Day15) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 7) {
			foreach (GameObject letter in Day16) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 8) {
			foreach (GameObject letter in Day21) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
		if (letterSet == 9) {
			foreach (GameObject letter in Day28) {
				letter.SetActive (true);
				gibMan.RandomTranslate ();
			}
		}
	}
}