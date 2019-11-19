using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class HighscoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private string secretKey = "mySecretKey"; // Edit this value and make sure it's the same as the one stored on the server
    public string displayHighscoreURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displayhighscore.php";
    public string postHighscoreURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/posthighscore.php";
    //public IDictionary<string, string> scoreDict = new Dictionary<string, string>();
    public List<KeyValuePair<string, string>> scoreList = new List<KeyValuePair<string, string>>();
    public Text[] names; // Array of Names
    public Text[] values; // Array of Values

    public string[] highScoreNames; // Position of Names
    public int[] highScoreValues; // Position of Values
    public List<KeyValuePair<string, string>> savedHighscores;
    // Start is called before the first frame update
    void Start()
    {

        
        StartCoroutine(GetHighscores());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator GetHighscores()
    {
        yield return StartCoroutine(PostHighscores(GameInfo.PlayerName, GameInfo.ScoreValue));
        UnityWebRequest www = UnityWebRequest.Get(displayHighscoreURL);
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {

            // Show results as text
            Debug.Log(www.downloadHandler.text);
            string webtext = www.downloadHandler.text;
            string[] webTextArray = webtext.Split(new string[] { "\n", "\r\n", " " }, StringSplitOptions.None);
            List<string> textArray = webTextArray.ToList();
            textArray.RemoveAt(textArray.Count - 1);
            textArray.RemoveAt(0);
            int x = 0;
            int y = 1;
            for (int i = 0; i < textArray.Count / 2; i++)
            {
                scoreList.Add(new KeyValuePair<string, string>(textArray[x], textArray[y]));
                
                x += 2;
                y += 2;
            }
            Debug.Log(scoreList.Count);
            GameInfo.Highscores = scoreList;
            StartHigh();

            x = 1;
            y = 2;




        }
    }
    IEnumerator PostHighscores(string name, int score)
        {
        WWWForm form = new WWWForm();

        // Assuming the perl script manages high scores for different games
    

        // The name of the player submitting the scores
        form.AddField("name", name);

        // The score
        form.AddField("score", score);
        UnityWebRequest hs_post = UnityWebRequest.Post(postHighscoreURL, form);

        // Wait until the download is done
        yield return hs_post.SendWebRequest();

        if (hs_post.isNetworkError || hs_post.isHttpError)
            {
                Debug.Log(hs_post.error);
            }
        else
        {
            // show the highscores
            Debug.Log(hs_post.downloadHandler.text);
        }

        
        
    }
    public void StartHigh() { 
        savedHighscores = GameInfo.Highscores;
       
        // Handling Names and Values
        highScoreNames = new string[names.Length];
        highScoreValues = new int[values.Length];
        for (int i = 0; i<savedHighscores.Count; i++)
        {
            var item = savedHighscores.ElementAt(i);
            highScoreNames[i] = item.Key;
            highScoreValues[i] = Int32.Parse(item.Value);
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
            for (int y = values.Length - 1; y > x; y--)
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
}
    
    

    


