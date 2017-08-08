using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class telegramSeven : MonoBehaviour
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
        text1.text = gibMan.gibberishText[119];
        text2.text = gibMan.gibberishText[120];
        text3.text = gibMan.gibberishText[121];
        text4.text = gibMan.gibberishText[122];
        text5.text = gibMan.gibberishText[123];
        text6.text = gibMan.gibberishText[124];
        text7.text = gibMan.gibberishText[125];
        text8.text = gibMan.gibberishText[126];
        text9.text = gibMan.gibberishText[127];


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
