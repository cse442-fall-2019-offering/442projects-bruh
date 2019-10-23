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
    public Sprite redCar;
    public Sprite blueCar;
    public Sprite greenCar;
    public Sprite blackCar;
    public Sprite whiteCar;
    public InputField inputField;
    public string newText;
    public float startTime;
    public int wordsCompleted;
    GameObject wpmTextBox;
    public Text textVar;
    void Start()
    {
       wordsCompleted = 0; // inits wordsCompleted
        wpmTextBox = GameObject.Find("wpm_var");
        textVar = wpmTextBox.GetComponent<Text>();
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
            //Debug.Log(newText + " was right");
            Correct();
            Change();
            updateSpeedo(IncrWPM());
        }
    }
    public void CheckWordOnEnter()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
        else {
            if(newText == GameInfo.PromptWord) {

                //Debug.Log(newText + " was right");
                Correct();
                Change();
                updateSpeedo(IncrWPM()); 
                
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

    public void Correct()
    {
        playerCar.transform.Translate(70,0,0);
        Debug.Log(playerCar.transform.position.x);
        if (playerCar.transform.position.x >= 1860)
        {
            GameInfo.count = false;
            GameWonPanel.SetActive(true);
            backgroundPanel.SetActive(false);
        }
    }

   /**
    * wpfarrel
    * Increments and calculates Words per minute
    * returns float of WPM
    */

    public float IncrWPM() 
    {
        float timeInSec = Time.fixedTime; //starts Time Delta
        Debug.Log("Time passed: " + timeInSec);
        wordsCompleted++; // Increase word count for calculating average
        Debug.Log("Words Completed: " + wordsCompleted);
        float currWPM = wordsCompleted / (timeInSec / 60); //Calc WPM
        Debug.Log("WPM = " + currWPM);
        return currWPM;
    }

    public void updateSpeedo(float wpm)
    {
        textVar.text = wpm.ToString();  //Updates speedo text with current wpm
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

