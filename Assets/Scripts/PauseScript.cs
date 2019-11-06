using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

/// <summary>
///  Controls pause functionality
/// </summary>

public class PauseScript : MonoBehaviour {
	public GameObject timePanel;
    public GameObject backgroundPanel;
    public GameObject gameOverPanel;
    public GameObject gameWonPanel;
	public GameObject pausePanel;
	public static bool isPaused = false;
	
    // Pauses or resumes game based on if game is paused (isPaused)
	public void pauseGame() {
	
		if (isPaused) {				//Start game again
			Time.timeScale = 1;
			isPaused = false;
			pausePanel.SetActive(false);
			backgroundPanel.SetActive(true);
		}
		else {						//pause game
			Time.timeScale = 0;
			isPaused = true;
			pausePanel.SetActive(true);
			gameOverPanel.SetActive(false);
			gameWonPanel.SetActive(false);
			backgroundPanel.SetActive(false);
			timePanel.SetActive(false);			//Disables the other panels/game elements other than the pause panel
		}
	}
}