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
    public GameObject GameWonPanel;
    public GameObject backgroundPanel;
    public GameObject playerCar;

    // Called on start of game canvas
    void Start()
    {
        inputField.enabled= false;
        
        switch (GameInfo.Theme)
        {
            case 1:
                playerCar.GetComponent <Image>().sprite = redCar;
                break;
            case 2:
                playerCar.GetComponent<Image>().sprite = blueCar;
                break;
            case 3:
                playerCar.GetComponent<Image>().sprite = greenCar;
                break;
            case 4:
                playerCar.GetComponent<Image>().sprite = blackCar;
                break;
            case 5:
                playerCar.GetComponent<Image>().sprite = whiteCar;
                break;

        }
    }

    /// Update is called every frame, if the MonoBehaviour is enabled.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            Debug.Log("Caps lock was pressed");
        }
    }
    
    // Changing the display of the input field and starting check word process if space is pressed
    public void UpdateInputText()
    {
        //set newtext
        newText = inputField.text;
        //
        if (Input.GetKeyDown("space"))
        {
            CheckWord();
            inputField.text = "";

        }
    }

    // Checks if inputed word matches prompted word and if so, initiates correct and change of prompted word
    public void CheckWord()
    {
        newText = newText.ToLower();
        if (newText.Length > 1)
        {
            newText = newText.Substring(0, newText.Length - 1);
        }
        if (newText == GameInfo.PromptWord)
        {
            Correct();
            Change();
        }
    }

    // Exception for if enter is used to submit words; same effect as CheckWord
    public void CheckWordOnEnter()
    {
        newText = newText.ToLower();
        if (Input.GetMouseButtonDown(0))
        {

        }
        else {
            if(newText == GameInfo.PromptWord) {
                Correct();
                Change();
                
            }
            inputField.text = "";
            inputField.Select();
            inputField.ActivateInputField();
        }
    }

    // Start change word process
    public void Change()
    {
        StartCoroutine(GetScores());
    }

    // Player has typed a word correctly and the car is pushed forward
    public void Correct()
    {
        playerCar.transform.Translate(70,0,0);
        // Check if player has reached end of the road
        // stop timer and bring up game won panel
        if (playerCar.transform.position.x >= 1860)
        {
            GameInfo.count = false;
            GameWonPanel.SetActive(true);
            backgroundPanel.SetActive(false);
        }
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
