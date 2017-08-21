using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XboxCtrlrInput;

public class employeeCon : MonoBehaviour
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
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;


    // Use this for initialization
    void Start()
    {
        gibMan = GameObject.FindGameObjectWithTag("GibberishManager").GetComponent<GibberishManager>();
        objInt = this.gameObject.GetComponentInChildren<ObjectInteract>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateText();
        MoveToStorage();
    }

    void UpdateText()
    {
        text1.text = gibMan.gibberishText[32];
        text2.text = gibMan.gibberishText[33];
        text3.text = gibMan.gibberishText[34];
        text4.text = gibMan.gibberishText[35];
        text5.text = gibMan.gibberishText[36];
        text6.text = gibMan.gibberishText[37]; //edited to remove "Dear Harriet Danvers,"
        text7.text = gibMan.gibberishText[38];
        text8.text = gibMan.gibberishText[39];
        text9.text = gibMan.gibberishText[40];
        text10.text = gibMan.gibberishText[41];
        text11.text = gibMan.gibberishText[42];
        text12.text = gibMan.gibberishText[43];
        text13.text = gibMan.gibberishText[44];
        text14.text = gibMan.gibberishText[45];
        text15.text = gibMan.gibberishText[46];
        text16.text = gibMan.gibberishText[47];

    }

    void MoveToStorage()
    {
        bool interCheck = objInt.anim.GetBool("Interact");
		if (interCheck == true && XCI.GetButtonDown(XboxButton.RightBumper) && objInt.isTargeted == true)
        {
            Debug.Log("Moving");
            GetComponent<Animator>().enabled = false;
            transform.position = empty.position;
            transform.rotation = empty.rotation;
        }
        else
            return;
    }
}
