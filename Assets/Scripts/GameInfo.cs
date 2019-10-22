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

    public static int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
            
    }
    public static int Theme
    {
        get { return theme; }
        set { theme = value; }

    }
    public static bool GameCount
    { 
        get { return count; }
        set { count = value; }

    }
    public static string PromptWord
    {
        get { return promptWord; }
        set { promptWord = value; }

    }
    public static string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }

    }

}
