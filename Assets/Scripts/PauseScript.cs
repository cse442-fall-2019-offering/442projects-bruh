using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {
	
	public static bool isPaused = false;
	
	public void pauseGame() {
	
		if (isPaused) {				//Start game again
			Time.timeScale = 1;
			isPaused = false;
		}
		else {						//pause game
			Time.timeScale = 0;
			isPaused = true;
		}
	}
}