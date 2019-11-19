using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameInfo 
{
    // Start is called before the first frame update
    public static int difficulty;
    public static string promptWord;
    public static string playerName;
    public static int theme;
    public static bool count;
    public static int scoreValue;
    public static List<KeyValuePair<string, string>> savedHighscores;

    // Difficulty of the game stored here
    public static int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
            
    }

    // List of saved highscores stored here
    public static List<KeyValuePair<string, string>> Highscores
    {
        get { return savedHighscores; }
        set { savedHighscores = value; }

    }

    // Theme of the game stored here
    public static int Theme
    {
        get { return theme; }
        set { theme = value; }

    }

    // Count boolean of the timer stored here
    public static bool GameCount
    { 
        get { return count; }
        set { count = value; }

    }

    // Prompted word of the game stored here
    public static string PromptWord
    {
        get { return promptWord; }
        set { promptWord = value; }

    }

    // Entered player name stored here
    public static string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }

    }

    // Final Score Value stored here
    public static int ScoreValue
    {
        get { return scoreValue; }
        set { scoreValue = value; }
    }

}
