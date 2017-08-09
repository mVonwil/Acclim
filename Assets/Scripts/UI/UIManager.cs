using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public PlayerMovement playMove;

	public Canvas pauseMenu;

	public Text display1;
	public Slider value1;
	public Text display2;
	public Slider value2;
	public Text buttondisplay;
	
	// Update is called once per frame
	void Update () {
		display1.text = "" + value1.value;
		display2.text = "" + value2.value;
	}

	public void TogglePauseMenu() {
		if (pauseMenu.enabled == true) {
			pauseMenu.enabled = false;
			Time.timeScale = 1.0f;
		} else {
			pauseMenu.enabled = true;
			Time.timeScale = 0f;
		}
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void InvertY(){
		if (playMove.invertY == false)
			playMove.invertY = true;
		else
			playMove.invertY = false;
	}
}
