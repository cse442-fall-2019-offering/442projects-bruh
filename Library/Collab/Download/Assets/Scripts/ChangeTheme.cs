﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTheme : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Dropdown myDropdown;
    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;



    // Update is called once per frame
    void Update()
    {
        if (GameInfo.Theme == 100)
        {
            myDropdown.value = 1;
            GameInfo.Theme = 1;
        }
        switch (myDropdown.value)
        {
            case 0:
                GameInfo.Theme = myDropdown.value;
                myDropdown.image.sprite = sprite0;
                break;
            case 1:
                GameInfo.Theme = myDropdown.value;
                myDropdown.image.sprite = sprite1;
                break;
            case 2:
                GameInfo.Theme = myDropdown.value;
                myDropdown.image.sprite = sprite2;
                break;
            case 3:
                GameInfo.Theme = myDropdown.value;
                myDropdown.image.sprite = sprite3;
                break;
            case 4:
                GameInfo.Theme = myDropdown.value;
                myDropdown.image.sprite = sprite4;
                break;
            case 5:
                GameInfo.Theme = myDropdown.value;
                myDropdown.image.sprite = sprite5;
                break;

        }

    }
}