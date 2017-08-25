using System.Collections;
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

	public List<GameObject> ObjectsDay1;
	public List<GameObject> ObjectsDay2;
	public List<GameObject> ObjectsDay5;
	public List<GameObject> ObjectsDay6;
	public List<GameObject> ObjectsDay7;
	public List<GameObject> ObjectsDay15;
	public List<GameObject> ObjectsDay16;
	public List<GameObject> ObjectsDay21;
	public List<GameObject> ObjectsDay28;

	public int letterSet;

	// Use this for initialization
	void Start () {
		gibMan = GameObject.FindGameObjectWithTag ("GibberishManager").GetComponent<GibberishManager> ();
		letterSet = 1;
		foreach (GameObject letter in Day1) {
			letter.SetActive (true);
		}
		foreach (GameObject misc in ObjectsDay1) {
			misc.SetActive (true);
		}
	}
	
	// Update is called once per frame
	public void Translate () {
		if (letterSet == 2) {
			foreach (GameObject letter in Day2) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 0; a < 172; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay2) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 3) {
			foreach (GameObject letter in Day5) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 172; a < 344; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay5) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 4) {
			foreach (GameObject letter in Day6) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 344; a < 516; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay6) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 5) {
			foreach (GameObject letter in Day7) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 516; a < 688; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay7) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 6) {
			foreach (GameObject letter in Day15) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 688; a < 860; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay15) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 7) {
			foreach (GameObject letter in Day16) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 860; a < 1032; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay16) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 8) {
			foreach (GameObject letter in Day21) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 1032; a < 1204; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay21) {
				misc.SetActive (true);
			}
		}
		if (letterSet == 9) {
			foreach (GameObject letter in Day28) {
				letter.SetActive (true);
				//gibMan.RandomTranslate ();
				AttemptLearning ();
				for (int a = 1204; a < 1556; a++)
					gibMan.Translated [a] = true;
			}
			foreach (GameObject misc in ObjectsDay28) {
				misc.SetActive (true);
			}
		}
	}

	void AttemptLearning(){
			gibMan.gibberishText.Clear ();
			gibMan.GenerateText ();
	}
}