using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GibberishManager : MonoBehaviour {

	public List<string> englishText;
	public List<string> uniqueTerms;
	public List<string> gibberishText;

	// Use this for initialization
	void Start () {
		List<string> tempEng = new List<string>(); //Temp list of string
		foreach (string msg in englishText) //For each element in list
			tempEng.Add (msg);

		foreach (string msg in tempEng) {
			string tempMsg = msg.Replace (".", ""); //Add a .Replace for each punctuation used
			string[] words = tempMsg.Split(' '); //Use String.Split to remove spaces
			foreach (string word in words) { //For each word in each array, check for duplicates
				if (!uniqueTerms.Contains (word)) //If word is unique, add to list
					uniqueTerms.Add (word); //bluffle - bluffel
			}
		}
			
		for (int i = 0; i < uniqueTerms.Count; i++) {
			//generate gibberish string
			gibberishText.Add("ewuovb");
		}

		//Create a list of strings. This list will contain all the words that have been translated. All other words will stay in gibberish


	}
	
	// Update is called once per frame
	void Update () {

	}
}
