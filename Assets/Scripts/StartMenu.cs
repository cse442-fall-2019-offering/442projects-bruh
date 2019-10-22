using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    
    public GameObject playerNamePanel;
    public GameObject startGamePanel;
    public GameObject difficultyError;
    public InputField inputField;
    void Start()
    {
        playerNamePanel.SetActive(false);
        difficultyError.SetActive(false);
    }
    public void SettingsScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayScene()
    {
        if (GameInfo.difficulty == 0)
        {
            playerNamePanel.SetActive(false);
            startGamePanel.SetActive(false);
            difficultyError.SetActive(true);
            GameInfo.difficulty = 100;
        }
        else
        {
            playerNamePanel.SetActive(true);
            startGamePanel.SetActive(false);
            difficultyError.SetActive(false);
            //SceneManager.LoadScene(3);
        }

    }
    public void PlayPanel()
    {
        playerNamePanel.SetActive(false);
        startGamePanel.SetActive(true);
        difficultyError.SetActive(false);
    }
    public void StatsScene()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitPress()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void InputHandle()
    {
        if (Input.GetMouseButtonDown(0))
        {



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

