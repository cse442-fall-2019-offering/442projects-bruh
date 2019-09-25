using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    public void SettingsPress()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayPress()
    {
        SceneManager.LoadScene(3);
    }
    public void StatsPress()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitPress()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
