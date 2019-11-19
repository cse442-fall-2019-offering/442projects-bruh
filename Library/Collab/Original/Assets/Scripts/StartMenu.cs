using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Start menu page controls and functionality
/// </summary>

public class StartMenu : MonoBehaviour
{
    public GameObject playerNamePanel;
    public GameObject startGamePanel;
    public GameObject difficultyError;
    public InputField inputField;

    // Called on start of start page canvas
    void Start()
    {
        playerNamePanel.SetActive(false);
        difficultyError.SetActive(false);
    }

    // Load settings screen
    public void SettingsScene()
    {
        SceneManager.LoadScene(1);
    }

    // Play game button pressed
    public void PlayScene()
    {
        // Check if a difficulty and theme were selected
        if (GameInfo.difficulty == 0 || GameInfo.Theme == 0)
        {
            playerNamePanel.SetActive(false);
            startGamePanel.SetActive(false);
            difficultyError.SetActive(true);
            GameInfo.difficulty = 100;
            GameInfo.Theme = 100;
        }
        else
        {
            playerNamePanel.SetActive(true);
            startGamePanel.SetActive(false);
            difficultyError.SetActive(false);
            ScoreScript.scoreValue = 0;
            GameInfo.ScoreValue = 0;
            //SceneManager.LoadScene(3);
        }

    }

    // Called when game instantiatd, makes sure proper panels are displayed
    public void PlayPanel()
    {
        playerNamePanel.SetActive(false);
        startGamePanel.SetActive(true);
        difficultyError.SetActive(false);
        ScoreScript.scoreValue = 0;
        GameInfo.ScoreValue = 0;
    }

    // Go to highscore page
    public void StatsScene()
    {
        SceneManager.LoadScene(4);
    }

    // Quit game
    // Called when quit button pressed
    public void QuitPress()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    // Handles different input methods
    public void InputHandle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // DO NOTHING
        }
        else
        {
            GameInfo.PlayerName = inputField.text;
            SceneManager.LoadScene(3);
            playerNamePanel.SetActive(false);
            difficultyError.SetActive(false);
        }
    }
    
}

