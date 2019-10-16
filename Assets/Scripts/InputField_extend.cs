using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputField_extend : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField inputField;
    public void InputFieldSelect()
    {
        
        inputField.Select();
        inputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
