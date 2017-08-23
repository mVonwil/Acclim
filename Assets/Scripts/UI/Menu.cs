using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using XboxCtrlrInput;

public class Menu : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (XCI.GetButton (XboxButton.X))
			SceneManager.LoadScene (1);
	}
}
