using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedo_Script : MonoBehaviour
{

    private const float max_speed_angle = 0;
    private const float zero_speed_angle = 150;

    private Transform needleTransform;

    GameObject wpm_textbox;

    private float speedMax;
    private float speed;

    public Text text_var;

    private void Awake() {
        needleTransform = transform.Find("needle");
        wpm_textbox= GameObject.Find("wpm_var");
        text_var = wpm_textbox.GetComponent<Text>();

        speed = 0f;
        speedMax = 150f;

    }  
    
    // Update is called once per frame
    void Update()
    {
        speed += 30f * Time.deltaTime;
        if (speed > speedMax) speed = speedMax;
        
        text_var.text = speed.ToString();
        needleTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation()); 
    }

    private float GetSpeedRotation() {
        float angleSize = zero_speed_angle - max_speed_angle;

        float normalizedSpeed = speed / speedMax;

        return (zero_speed_angle - normalizedSpeed) * angleSize;

    }
}
