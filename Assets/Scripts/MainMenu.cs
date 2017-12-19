 using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

//Controls the game flow

public class MainMenu : MonoBehaviour {


	public void newGame(){
		SceneManager.LoadScene(1);
	}

	public void returnFromInstructions(){
		SceneManager.LoadScene(0);
	}

	public void goToInstructions(){
		SceneManager.LoadScene (2);
	}
}
