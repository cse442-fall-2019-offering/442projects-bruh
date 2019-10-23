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

    void Start()
    {
        GameInfo.difficulty = 0;
        myDropdown.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameInfo.difficulty== 100)
        {
            myDropdown.value = 1;
            GameInfo.Difficulty = 1;
        }
        switch (myDropdown.value)
        {
            case 0:

                myDropdown.image.sprite = sprite0;
                GameInfo.difficulty = myDropdown.value;
                break;
            case 1:

                
                myDropdown.image.sprite = sprite1;
                GameInfo.difficulty = myDropdown.value;

                break;
            case 2:
                myDropdown.image.sprite = sprite2;
                GameInfo.difficulty = myDropdown.value;
                break;
            case 3:
                myDropdown.image.sprite = sprite3;
                GameInfo.difficulty = myDropdown.value;
                break;
        }
        
    }
}
