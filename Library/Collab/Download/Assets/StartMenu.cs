using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public void SettingsScene()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayScene()
    {
        SceneManager.LoadScene(3);
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
}
