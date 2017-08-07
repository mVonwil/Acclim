﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelegramSeven : MonoBehaviour
{

    GibberishManager gibMan;
	ObjectInteract objInt;
	public Transform empty;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;



    // Use this for initialization
    void Start()
    {
        gibMan = GameObject.FindGameObjectWithTag("GibberishManager").GetComponent<GibberishManager>();
		objInt = this.gameObject.GetComponentInChildren<ObjectInteract> ();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
		MoveToStorage ();
    }

    void UpdateText()
    {
        text1.text = gibMan.gibberishText[118];
        text2.text = gibMan.gibberishText[119];
        text3.text = gibMan.gibberishText[120];
        text4.text = gibMan.gibberishText[121];
        text5.text = gibMan.gibberishText[122];

    }

	void MoveToStorage(){
		bool interCheck = objInt.anim.GetBool ("Interact");
		if (interCheck == true && Input.GetMouseButtonDown(0) && objInt.isTargeted == true) {
			Debug.Log ("Moving");
			GetComponent<Animator> ().enabled = false;
			transform.position = empty.position;
			transform.rotation = empty.rotation;
		} else
			return;
	}
}
