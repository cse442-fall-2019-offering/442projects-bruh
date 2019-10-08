using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordPull : MonoBehaviour
{
    public GameObject wordDisplay;

    public void PullWord()
    {
        string[] allWords = System.IO.File.ReadAllLines(@"Assets\Words.txt");
        int numWords = allWords.Length;
        int index = Random.Range(0,numWords);
        wordDisplay.GetComponent<Text>().text = allWords[index];
    }

}
