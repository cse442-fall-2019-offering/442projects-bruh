using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    // Go back to home page from stats game
    public void HomeScene()
    {
        SceneManager.LoadScene(2);
    }
}
