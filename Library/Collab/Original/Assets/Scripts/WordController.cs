using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WordController : MonoBehaviour
{
    private string secretKey = "mySecretKey"; // Edit this value and make sure it's the same as the one stored on the server
    public string addScoreURL = "http://localhost/unity_test/addscore.php?"; //be sure to add a ? to your url
    public string displayWordEasyURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displaywordeasy.php";
    public string displayWordMedURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displaywordmed.php";
    public string displayWordHardURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displaywordhard.php";
    public GameObject wordDisplay;
    public InputField inputField;
    public string newText;
    
    void Start()
    {
        inputField.enabled= false;
   
    }
    /// Update is called every frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            Debug.Log("Caps lock was pressed");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed");
        }
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
        if (newText == GameInfo.PromptWord)
        {
            Debug.Log(newText + " was right");
            Change();
        }
    }
    public void CheckWordOnEnter()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
        else {
            if(newText == GameInfo.PromptWord) { 
        
                Debug.Log(newText + " was right");
                Change();
            }
            inputField.text = "";
            inputField.Select();
            inputField.ActivateInputField();
        }
    }
    public void Change()
    {
        StartCoroutine(GetScores());
    }



    // Get the scores from the MySQL DB to display in a GUIText.
    // remember to use StartCoroutine when calling this function!
    IEnumerator GetScores()
    {
        int num = GameInfo.difficulty;
        if (num == 1)
        {
            UnityWebRequest www = UnityWebRequest.Get(displayWordEasyURL);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {

                // Show results as text
                Debug.Log(www.downloadHandler.text);
                string webtext = www.downloadHandler.text;
                string[] webTextArray = webtext.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None);
                wordDisplay.GetComponent<Text>().text = webTextArray[1];
                GameInfo.PromptWord = webTextArray[1];


            }
        }
        if (num == 2)
        {
            UnityWebRequest www = UnityWebRequest.Get(displayWordMedURL);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {

                // Show results as text
                Debug.Log(www.downloadHandler.text);
                string webtext = www.downloadHandler.text;
                string[] webTextArray = webtext.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None);
                wordDisplay.GetComponent<Text>().text = webTextArray[1];
                GameInfo.PromptWord = webTextArray[1];


            }
        }
        if (num == 3)
        {
            UnityWebRequest www = UnityWebRequest.Get(displayWordHardURL);
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {

                // Show results as text
                Debug.Log(www.downloadHandler.text);
                string webtext = www.downloadHandler.text;
                string[] webTextArray = webtext.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.None);
                wordDisplay.GetComponent<Text>().text = webTextArray[1];
                GameInfo.PromptWord = webTextArray[1];


            }
        }
    }

}
