using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelegramTwo : MonoBehaviour
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
        text1.text = gibMan.gibberishText[35];
        text2.text = gibMan.gibberishText[36];
        text3.text = gibMan.gibberishText[37];
        text4.text = gibMan.gibberishText[38];
        text5.text = gibMan.gibberishText[39];
        text6.text = gibMan.gibberishText[40];
        text7.text = gibMan.gibberishText[41];
    }
}
