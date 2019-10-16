using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

[RequireComponent(typeof(Button))]
public class Game : MonoBehaviour {
    public string dispaywordURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displayword.php";
    public bool isMute = false;
    public InputField inputField;
    public string newText;
    public string newWord;
    public GameObject wordDisplay;

    public void HomeScene()
    {
        SceneManager.LoadScene(2); 
    }
    public void SettingsScene() //loads settings scene
    {
        SceneManager.LoadScene(1);
    }
    public void Mute() //Mutes audio on button press
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;

    }
    public void UpdateInputText()
    {
        //set newtext
        newText = inputField.text;
        if (Input.GetKeyDown("space"))
        {
            CheckWord();
            inputField.text = "";
        }

    }
    public void CheckWord()
    {
        if (newText.Length > 1)
        {
            newText = newText.Substring(0, newText.Length - 1);
        }
        if (newText == newWord)
        {
            Debug.Log(newText + " was right");
        }
    }

    public void PullWord()
    {
        
            string[] allWords = System.IO.File.ReadAllLines(@"Assets\Words.txt");
            int numWords = allWords.Length;
            int index = Random.Range(0, numWords);
            newWord = allWords[index];
            wordDisplay.GetComponent<Text>().text = allWords[index];
        
    }
}