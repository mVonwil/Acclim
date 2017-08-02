﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelegramSix : MonoBehaviour
{

    GibberishManager gibMan;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;



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
        text1.text = gibMan.gibberishText[91];
        text2.text = gibMan.gibberishText[92];
        text3.text = gibMan.gibberishText[93];
        text4.text = gibMan.gibberishText[94];
        text5.text = gibMan.gibberishText[95];
        text6.text = gibMan.gibberishText[96];

    }
}