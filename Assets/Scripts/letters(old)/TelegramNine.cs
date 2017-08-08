using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelegramNine : MonoBehaviour
{

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
    public Text text10;
    public Text text11;
    public Text text12;
    public Text text13;



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
        text1.text = gibMan.gibberishText[150];
        text2.text = gibMan.gibberishText[151];
        text3.text = gibMan.gibberishText[152];
        text4.text = gibMan.gibberishText[153];
        text5.text = gibMan.gibberishText[154];
        text6.text = gibMan.gibberishText[155];
        text7.text = gibMan.gibberishText[156];
        text8.text = gibMan.gibberishText[157];
        text9.text = gibMan.gibberishText[158];
        text10.text = gibMan.gibberishText[159];
        text11.text = gibMan.gibberishText[160];
        text12.text = gibMan.gibberishText[161];
        text13.text = gibMan.gibberishText[162];
    }
}
