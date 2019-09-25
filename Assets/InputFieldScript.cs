using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldScript : MonoBehaviour{
	public InputField inputField;
	
	public string newText;
	
	public void Update(){
		
		//set newtext
		newText = inputField.text;
		
		if(Input.GetKeyDown(KeyCode.Return)){
		//display text in console on enter press
		Debug.Log(newText);
		
		}
	}
	
}
		


