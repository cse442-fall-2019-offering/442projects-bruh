using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controls button presses from main menu
/// </summary>

public class MainMenu : MonoBehaviour {

    // Goes to next scene
    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Play pressed, go to game screen
    public void PlayScene()
    {
        SceneManager.LoadScene(2);
    }

    // Settings pressed, go to settings page
    public void SettingsScene()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        if (Input.GetKeyDown("f") & Input.GetKeyDown("u") & Input.GetKeyDown("r") & Input.GetKeyDown("y"))
        {
            Debug.Log("hello");
        }
    }
}