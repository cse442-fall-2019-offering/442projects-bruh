using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InputFieldScript : MonoBehaviour{
    public InputField inputField;

    public string newText;

    public string newWord;

    public void UpdateInputText(){
        //set newtext
        newWord = "fool";
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


    }
		


