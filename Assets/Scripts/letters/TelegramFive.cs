using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelegramFive : MonoBehaviour
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
        text1.text = gibMan.gibberishText[75];
        text2.text = gibMan.gibberishText[76];
        text3.text = gibMan.gibberishText[77];
        text4.text = gibMan.gibberishText[78];
        text5.text = gibMan.gibberishText[79];
        text6.text = gibMan.gibberishText[80];

    }
}
