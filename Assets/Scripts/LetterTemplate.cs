using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterTemplate : MonoBehaviour
{

    GibberishManager gibMan;
    public Text letterOne;

    // Use this for initialization
    void Start()
    {
        gibMan = GameObject.FindGameObjectWithTag("GibberishManager").GetComponent<GibberishManager>();
    }

    // Update is called once per frame
    void Update()
    {
        letterOne.text = gibMan.gibberishText[0];
    }
}
