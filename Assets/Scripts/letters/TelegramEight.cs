using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelegramEight : MonoBehaviour
{

    GibberishManager gibMan;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;



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
        text1.text = gibMan.gibberishText[123];
        text2.text = gibMan.gibberishText[124];
        text3.text = gibMan.gibberishText[125];
        text4.text = gibMan.gibberishText[126];
        text5.text = gibMan.gibberishText[127];
        text6.text = gibMan.gibberishText[128];
        text7.text = gibMan.gibberishText[129];

    }
}
