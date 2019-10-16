using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InputFieldScript : MonoBehaviour{
<<<<<<< Updated upstream:Assets/InputFieldScript.cs
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
=======
	public InputField inputField;
	
	private string newText;
	private List<string> answers = new List<string>();
	
	
	public void UpdateInputText(){
		//set newtext
		newText = inputField.text;
		
		if(Input.GetKeyDown(KeyCode.Return)){	//displays text and then outputs them in console
			answers.Add(newText);
			foreach(string n in answers){
				Debug.Log(n);
			}
		}
	}
}
>>>>>>> Stashed changes:Assets/Scripts/InputFieldScript.cs
		


