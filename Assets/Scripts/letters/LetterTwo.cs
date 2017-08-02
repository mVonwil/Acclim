using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterTwo : MonoBehaviour
{
	
    GibberishManager gibMan;
	ObjectInteract objInt;
	public Transform empty;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;


    // Use this for initialization
    void Start()
    {
        gibMan = GameObject.FindGameObjectWithTag("GibberishManager").GetComponent<GibberishManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
    }

    void UpdateText()
    {
        text1.text = gibMan.gibberishText[8];
        text2.text = gibMan.gibberishText[9];
        text3.text = gibMan.gibberishText[10];
        text4.text = gibMan.gibberishText[11];
        text5.text = gibMan.gibberishText[12];
        text6.text = gibMan.gibberishText[13];
        text7.text = gibMan.gibberishText[14];
        text8.text = gibMan.gibberishText[15];
        text9.text = gibMan.gibberishText [16];
        text10.text = gibMan.gibberishText[17];
        text11.text = gibMan.gibberishText[18];

    }
}
