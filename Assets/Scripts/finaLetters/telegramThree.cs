using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telegramThree : MonoBehaviour
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
        text1.text = gibMan.gibberishText[48];
        text2.text = gibMan.gibberishText[49];
        text3.text = gibMan.gibberishText[50];
        text4.text = gibMan.gibberishText[51];
        text5.text = gibMan.gibberishText[52];
        text6.text = gibMan.gibberishText[53];
        text7.text = gibMan.gibberishText[54];
        text8.text = gibMan.gibberishText[55];
        text9.text = gibMan.gibberishText[56];

    }

    void MoveToStorage()
    {
        bool interCheck = objInt.anim.GetBool("Interact");
        if (interCheck == true && Input.GetMouseButtonDown(0) && objInt.isTargeted == true)
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
