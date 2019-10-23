using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Holds all global variables for various game status values and fields
/// </summary>

public static class GameInfo 
{
    // Start is called before the first frame update
    public static int difficulty;
    public static string promptWord;

    // Difficulty of the game stored here
    public static int Difficulty
    {
        get { return difficulty; }
        set { difficulty = value; }
    }

<<<<<<< HEAD
=======
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
>>>>>>> issue31_carmodels
    public static string PromptWord
    {
        get { return promptWord; }
        set { promptWord = value; }
    }
<<<<<<< HEAD
=======

    // Entered player name stored here
    public static string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
>>>>>>> issue31_carmodels

}
