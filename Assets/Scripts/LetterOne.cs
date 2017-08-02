using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterOne : MonoBehaviour {

	GibberishManager gibMan;
	public Text text1;
	public Text text2;
	public Text text3;
	public Text text4;
	public Text text5;
	public Text text6;
	public Text text7;
	public Text text8;
	public Text text9;


	// Use this for initialization
	void Start () {
		gibMan = GameObject.FindGameObjectWithTag ("GibberishManager").GetComponent<GibberishManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateText ();
	}

	void UpdateText(){
		text1.text = gibMan.gibberishText [0];
		text2.text = gibMan.gibberishText [1];
		text3.text = gibMan.gibberishText [2];
		text4.text = gibMan.gibberishText [3];
		text5.text = gibMan.gibberishText [4];
		text6.text = gibMan.gibberishText [5];
		text7.text = gibMan.gibberishText [6];
		text8.text = gibMan.gibberishText [7];
		text9.text = gibMan.gibberishText [178];
	}
}
