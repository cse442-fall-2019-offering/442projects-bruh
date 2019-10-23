using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + scoreValue;
    }
}
