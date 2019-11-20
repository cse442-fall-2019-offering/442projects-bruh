using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

[RequireComponent(typeof(Button))]
public class Game : MonoBehaviour {
    //public string dispaywordURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displayword.php";
    public bool isMute = false;
    public InputField inputField;
    public string newText;
    public string newWord;
    public GameObject wordDisplay;

    public void HomeScene()
    {
        SceneManager.LoadScene(2);
    }
    public void SettingsScene()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitPress()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;

    }
    

    // Used to pull words from local file
    public void PullWord()
    {
            string[] allWords = System.IO.File.ReadAllLines(@"Assets\Words.txt");
            int numWords = allWords.Length;
            int index = Random.Range(0, numWords);
            newWord = allWords[index];
            wordDisplay.GetComponent<Text>().text = allWords[index];
    }
}