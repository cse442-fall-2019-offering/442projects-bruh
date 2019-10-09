using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDropdownSprite : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TMP_Dropdown myDropdown;
    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;



    // Update is called once per frame
    void Update()
    {
        switch (myDropdown.value)
        {
            case 0:
                myDropdown.image.sprite = sprite0;
                break;
            case 1:
                myDropdown.image.sprite = sprite1;
                break;
            case 2:
                myDropdown.image.sprite = sprite2;
                break;
            case 3:
                myDropdown.image.sprite = sprite3;
                break;
        }
        
    }
}
