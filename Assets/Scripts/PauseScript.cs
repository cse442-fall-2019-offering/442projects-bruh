using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Controls pause functionality
/// </summary>

public class PauseScript : MonoBehaviour {
	public static bool isPaused = false;
	
    // Pauses or resumes game based on if game is paused (isPaused)
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