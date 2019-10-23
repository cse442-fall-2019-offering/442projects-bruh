using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * GetComponent<HighScore>().CheckForHighScore(score, playerName.text);   (PLACE THIS WHERE GAME ENDS)
 */

public class HighScore : MonoBehaviour
{
    public Text[] names; // Array of Names
    public Text[] values; // Array of Values

    public string[] highScoreNames; // Position of Names
    public int[] highScoreValues; // Position of Values

    // Start is called before the first frame update
    public void Start()
    {
        // Handling Names and Values
        highScoreNames = new string[names.Length];
        highScoreValues = new int[values.Length];
        for (int x = 0; x < values.Length; x++)
        {
            highScoreNames[x] = PlayerPrefs.GetString("highScoreNames" + x); // Populates list with names
            highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x); // Populates list with values
        }
        DrawScores();
    }

    // Saves Leaderboard
    public void SaveScores()
    {
        for (int x = 0; x < values.Length; x++)
        {
            PlayerPrefs.SetString("highScoreNames" + x, highScoreNames[x]); // Setting names from appropriate list
            PlayerPrefs.SetInt("highScoreValues" + x, highScoreValues[x]); // Setting values from appropriate list
        }
    }

    // Check to See if a "new" Score is, in fact, a High Score
    public void CheckForHighScore(int _value, string _userName)
    {
        for (int x = 0; x < values.Length; x++)
        {
            if (_value > highScoreValues[x]) // If a "new" High Score is greater than a current High Score
            {
                for (int y = values.Length -1; y > x; y--)
                {
                    highScoreValues[y] = highScoreValues[y - 1]; // Moves the scores from the position of the "new" High Score down
                    highScoreNames[y] = highScoreNames[y - 1]; // Moves the names from the position of the "new" High Score down
                }
                highScoreValues[x] = _value;
                highScoreNames[x] = _userName;
                DrawScores();
                SaveScores();
                break;
            }
        }
    }

    // Draw Names and Scores to Display
    public void DrawScores()
    {
        for (int x = 0; x < values.Length; x++)
        {
            names[x].text = highScoreNames[x].ToString(); // Places names onto the screen
            values[x].text = highScoreValues[x].ToString(); // Places values onto the screen
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
