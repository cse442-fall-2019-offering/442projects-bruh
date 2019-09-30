using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InputFieldScript : MonoBehaviour{
	public InputField inputField;
	
	public string newText;
	private List<string> answers = new List<string>();
	
	
	public void UpdateInputText(){
		//set newtext
		newText = inputField.text;
		
		if(Input.GetKeyDown(KeyCode.Return)){
			answers.Add(newText);
			foreach(string n in answers){
				Debug.Log(n);
			}
		}
	}
}
		


