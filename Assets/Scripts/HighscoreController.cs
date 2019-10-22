using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class HighscoreController : MonoBehaviour
{
    // Start is called before the first frame update
    private string secretKey = "mySecretKey"; // Edit this value and make sure it's the same as the one stored on the server
    public string displayHighscoreURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/displayhighscore.php";
    public string postHighscoreURL = "https://www-student.cse.buffalo.edu/CSE442-542/2019-Fall/cse-442a/posthighscore.php";
    public IDictionary<string, string> scoreDict = new Dictionary<string, string>();
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
        yield return StartCoroutine(PostHighscores(GameInfo.PlayerName, 100));
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
                scoreDict.Add(textArray[x], textArray[y]);
                x += 2;
                y += 2;
            }
            Debug.Log(scoreDict.Count);
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
}
    
    

    


