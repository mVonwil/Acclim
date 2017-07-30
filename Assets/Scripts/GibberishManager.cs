using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GibberishManager : MonoBehaviour {

	public List<string> englishText;
	public List<string> uniqueTerms;
	public List<string> gibTerms;
	public List<bool> Translated;
	public List<string> gibberishText;

	public string gibberish;

	// Use this for initialization
	void Start () {
		List<string> tempEng = new List<string> (); //Temp list of english strings
		List<string> tempGib = new List<string> (); //Temp list of gibberish strings

		foreach (string msg in englishText) //For each element in list
			tempEng.Add (msg);

		foreach (string msg in tempEng) {
			string tempMsg = msg.Replace (".", ""); //Add a .Replace for each punctuation used
			string[] words = tempMsg.Split (' '); //Use String.Split to seperate the words and put them in an array
			foreach (string word in words) { //For each word in each array, check for duplicates
				if (!uniqueTerms.Contains (word)) { //If word is unique, add to list
					uniqueTerms.Add (word); //bluffle - bluffel
					tempGib.Add (word);
				}
			}
		}
			
		for (int i = 0; i < 26; i++) {
			//generate gibberish string - auto translate (letter replacer)
			string tempWord = tempGib [i];
			string transWord = tempWord.Replace ("a", "s").Replace ("q", "w").Replace ("z", "x").Replace ("c", "v").Replace ("d", "f").Replace ("e", "r").Replace ("t", "y").Replace ("g", "h").Replace ("b", "n").Replace ("m", "j").Replace ("u", "i").Replace ("k", "l").Replace ("o", "p");
			tempGib.Add (transWord);
		}

		for (int i = 0; i < 26; i++)
			tempGib.Remove (tempGib [0]);

		gibTerms = tempGib;
		//Create a list of strings. This list will contain all the words that have been translated. All other words will stay in gibberish

		GenerateText ();

	}
	
	// Update is called once per frame
	void Update () {




	}

	void GenerateText(){
		for (int a = 0; a < englishText.Count; a++){
			string engText = englishText[a];
			string gibText = "";
			string transText = engText.Replace (".", "");
			string[] engWords = transText.Split (' ');
			foreach (string word in engWords) {
				int wordLocation = uniqueTerms.IndexOf (word);
				string wordSwap = gibTerms [wordLocation];
				if (Translated [wordLocation] == false)
					gibText += " " + wordSwap;
				else
					gibText += " " + word;
				gibberish = gibText;
			}
			gibberishText.Add(gibberish);
		}
	}
}